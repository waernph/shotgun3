class Player
{
    private bool _isHuman;
    public bool IsHuman
    {
        get { return _isHuman; }
        private set { _isHuman = value; }
    }

    public Player(bool isHuman)
    {
        IsHuman = isHuman;
    }

    private bool correctInput = true;

    ShotsLeft sl = new ShotsLeft();

    //---------------------------------------------------------------
    // Metoder för att reutrnera skott, subtrahera/addera skott
    public int DisplayPlayersShots()
    {
        return sl.Shots;
    }

    private void Action(char userInput)
    {
        sl.AddOrSubtractShot(userInput);
    }

    //---------------------------------------------------------------
    private char PlayerInput()
    {
        string[] Options = //String-array för vad som ska skrivas ut.

            //I if-satsen nedan bestäms vilket index i arrayen som ska skrivas ut beroende av DisplayShotsLeft
            [
                "Välj (L)adda eller (B)locka ",
                "Välj (S)kjut, (L)adda eller (B)locka ",
                "Välj (S)kjut, (L)adda, (B)locka eller (H)agelgevär",
            ];
        if (DisplayPlayersShots() > 0 && DisplayPlayersShots() < 3)
        {
            Console.Write(Options[1]);
        }
        else if (DisplayPlayersShots() >= 3)
        {
            Console.Write(Options[2]);
        }
        else
        {
            Console.Write(Options[0]);
        }
        return char.ToLower(Console.ReadKey().KeyChar);
    }

    public int PlayerChoice()
    {
        int choice = 1;
        do
        {
            char userInput;
            if (IsHuman) //Avgör om spelare ska få välja eller om det ska slumpas
            {
                userInput = PlayerInput();
            }
            else
            {
                userInput = ComputerRandomRoll();
            }

            switch (userInput)
            {
                case 's':
                    if (DisplayPlayersShots() > 0)
                    {
                        Action(userInput);
                        choice = 1;
                        break;
                    }
                    else
                    {
                        choice = 100; //Felkod. Inga skott
                        goto default;
                    }

                case 'l':
                    Action(userInput);
                    choice = 2;
                    break;

                case 'b':
                    choice = 3;
                    break;

                case 'h':
                    if (DisplayPlayersShots() >= 3)
                    {
                        choice = 4;
                        break;
                    }
                    else
                    {
                        choice = 102; //felkod. inte tillräckligt med skott för shotgun.
                        goto default;
                    }

                default:
                    if (choice != 100 && choice != 102)
                    {
                        choice = 101; //felkod. felaktigt knapptryck
                    }
                    break;
            }
            Console.Clear();
            Graphics.ShotgunLogo();
            if (choice >= 100)
            {
                Console.Clear();
                Graphics.ShotgunLogo();
                correctInput = false;
                Graphics.NotValidInput(choice);
            }
            else
            {
                correctInput = true;
            }
        } while (!correctInput);

        return choice;
    }

    private char ComputerRandomRoll()
    {
        string choices = "ssllbbhhhh";
        int index = 0;

        if (DisplayPlayersShots() == 0)
        {
            index = RandomHelper.ComputerRandomInterval23();
        }
        else if (DisplayPlayersShots() > 0 && DisplayPlayersShots() < 2)
        {
            index = RandomHelper.ComputerRandomInterval05();
        }
        else if (DisplayPlayersShots() == 2)
        {
            index = RandomHelper.ComputerRandomInterval14();
        }
        else if (DisplayPlayersShots() >= 3)
        {
            index = RandomHelper.ComputerRandomInterval59();
        }
        return choices[index];
    }
}
