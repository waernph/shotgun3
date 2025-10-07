class Program
{
    public static void Main()
    {
        Graphics.ShotgunLogoAnimation();
        bool restart = true;
        Console.Title = "SHOTGUN!";

        while (restart)
        {
            bool playerTwo = Graphics.PlayerIsHuman();
            Player player1 = new Player(true);
            Player player2 = new Player(playerTwo);
            bool gameOn = true;
            bool validInput = false;
            char userInput;
            while (gameOn)
            {
                Graphics.AntalSkott(player1, player2);
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Spelare 1");
                Console.ForegroundColor = ConsoleColor.Gray;
                int player1Choice = player1.PlayerChoice();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Spelare 2");
                Console.ForegroundColor = ConsoleColor.Gray;
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
                    Console.Clear();
                    Graphics.ShotgunLogo();
                    Graphics.AntalSkott(player1, player2);
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine($"\n{winner} vann med {weapon}!");
                    Console.ForegroundColor = ConsoleColor.Gray;
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
                            Console.WriteLine($"{winner} vann med {weapon}!");
                        }
                    }
                    gameOn = false;
                }
            }
        }
    }
}
