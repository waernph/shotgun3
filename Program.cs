using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

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
            while (player1.correctInput)
            {
                Console.Clear();
                gfx.ShotgunLogo();
                Console.WriteLine(
                    $"Spelare 1: {player1.DisplayPlayersShots()} skott   |   Spelare 2: {player2.DisplayPlayersShots()} skott"
                );
                player1.PlayerChoice();
            }
            player2.PlayerChoice();
        }
    }
}
