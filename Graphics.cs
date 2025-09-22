class Graphics
{
    public static void ShotgunLogo()
    {
        Console.WriteLine(
            @"
     ____  _   _  ___ _____ ____ _   _ _   _ _
    / ___|| | | |/ _ \_   _/ ___| | | | \ | | |
    \___ \| |_| | | | || || |  _| | | |  \| | |
     ___) |  _  | |_| || || |_| | |_| | |\  |_|
    |____/|_| |_|\___/ |_| \____|\___/|_| \_(_) 
    "
        );
    }

    public static void NewGraphic(Player player1, Player player2)
    {
        Console.Clear();
        ShotgunLogo();
        Console.WriteLine(
            $"Spelare 1: {player1.DisplayPlayersShots()} skott   |   Spelare 2: {player2.DisplayPlayersShots()} skott"
        );
    }
}
