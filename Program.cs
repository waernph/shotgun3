class Program
{
    public static void Main()
    {
        Graphics.ShotgunLogo();
        bool restart = true;
        bool playerTwo;
        Console.WriteLine("Vill du spela mot datorn? Y/N");
        char PlayerIsHuman = char.ToLower(Console.ReadKey().KeyChar);
        if (PlayerIsHuman == 'y')
        {
            playerTwo = false;
        }
        else if (PlayerIsHuman == 'n')
        {
            playerTwo = true;
        }
        else
        {
            Console.WriteLine("Felaktig inmatning. Spelare två satt till dator");
            playerTwo = false;
        }

        while (restart)
        {
            Player player1 = new Player(true);
            Player player2 = new Player(playerTwo);
            bool gameOn = true;
            bool validInput = false;
            char userInput;
            while (gameOn)
            {
                Graphics.AntalSkott(player1, player2);
                Console.WriteLine("Spelare 1");
                int player1Choice = player1.PlayerChoice();
                Console.WriteLine("Spelare 2");
                int player2Choice = player2.PlayerChoice();
                string winner = Winner.WinnerIs(player1Choice, player2Choice);
                if (winner == "Spelare 1" || winner == "Spelare 2")
                {
                    string weapon = "";
                    if (player1Choice == 1 || player2Choice == 1)
                    {
                        weapon = "pistol";
                    }
                    if (player1Choice == 4 || player2Choice == 4)
                    {
                        weapon = "hagelgevär";
                    }

                    Console.WriteLine($"\n\n{winner} vann med {weapon}!");
                    while (!validInput)
                    {
                        Graphics.PlayAgain();
                        userInput = char.ToLower(Console.ReadKey().KeyChar);
                        if (userInput == 'y')
                        {
                            restart = true;
                            validInput = true;
                        }
                        else if (userInput == 'n')
                        {
                            restart = false;
                            validInput = true;
                        }
                        else
                        {
                            validInput = false;
                            Console.Clear();
                            //Graphics.NewGraphic(player1, player2);
                            Console.WriteLine($"{winner} vann med {weapon}!");
                        }
                    }
                    gameOn = false;
                }
            }
        }
    }
}
