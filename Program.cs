class Program
{
    public static void Main()
    {
        Player player1 = new Player(true);
        Player player2 = new Player(false);
        Graphics gfx = new Graphics();
        bool gameOn = true;

        while (gameOn)
        {
            Console.Clear();
            gfx.ShotgunLogo();
            Console.WriteLine(
                $"Spelare 1: {player1.DisplayPlayersShots()} skott   |   Spelare 2: {player2.DisplayPlayersShots()} skott"
            );
            int player1Choice = player1.PlayerChoice();
            int player2Choice = 4 /*player2.PlayerChoice()*/;
            Console.WriteLine(player2Choice);
            string winner = Winner.WinnerIs(player1Choice, player2Choice);
            if (winner == "Spelare 1" || winner == "Spelare 2")
            {
                Console.WriteLine($"\n{winner} vann!");
                gameOn = false;
            }
        }
    }
}
 