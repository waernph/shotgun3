class Program
{
    public static void Main()
    {
        Player player1 = new Player(true);
        Player player2 = new Player(false);
        Graphics gfx = new Graphics();

        Console.Clear();
        gfx.ShotgunLogo();
        player1.LoadShot();
        Console.WriteLine(
            $"Spelare 1: {player1.DisplayPlayersShots()} skott   |   spelare 2: {player2.DisplayPlayersShots()} skott"
        );

    }
}
