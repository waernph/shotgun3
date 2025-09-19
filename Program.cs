using System.Security.Cryptography.X509Certificates;

class Program
{
    public static void Main()
    {
        bool restart = true;
        while (restart)
        {
            Player player1 = new Player(true);
            Player player2 = new Player(false);
            bool gameOn = true;
            bool validInput = false;
            char userInput;

            while (gameOn)
            {
                Console.Clear();
                Graphics.ShotgunLogo();
                Console.WriteLine(
                    $"Spelare 1: {player1.DisplayPlayersShots()} skott   |   Spelare 2: {player2.DisplayPlayersShots()} skott"
                );
                int player1Choice = player1.PlayerChoice();
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
                        Console.WriteLine("\nVill du spela igen? Y/N");
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
                        }
                    }
                    gameOn = false;
                }
            }
        }
    }
}
