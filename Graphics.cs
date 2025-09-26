using Microsoft.VisualBasic;

static class Graphics
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

    public static void ShotgunLogoAnimation()
    {
        string shotgunAnimation =
            @"
     ____  _   _  ___ _____ ____ _   _ _   _ _
    / ___|| | | |/ _ \_   _/ ___| | | | \ | | |
    \___ \| |_| | | | || || |  _| | | |  \| | |
     ___) |  _  | |_| || || |_| | |_| | |\  |_|
    |____/|_| |_|\___/ |_| \____|\___/|_| \_(_) 
    ";
        Console.CursorVisible = false;
        foreach (var item in shotgunAnimation)
        {
            Console.Write(item);
            Thread.Sleep(1);
        }
        Console.CursorVisible = true;
    }

    public static void AntalSkott(Player player1, Player player2)
    {
        Console.Clear();
        ShotgunLogo();
        Console.WriteLine(
            $"Spelare 1: {player1.DisplayPlayersShots()} skott   |   Spelare 2: {player2.DisplayPlayersShots()} skott"
        );
    }

    public static void NotValidInput(int choice)
    {
        int time = 3;
        choice -= 100;
        string[] errorMessage =
        [
            "Du har inga skott, försök inte!",
            "Valet finns inte. Försök igen",
            "Du måste ha minst 3 skott",
        ];
        Console.Beep();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\n" + errorMessage[choice]);
        Console.ForegroundColor = ConsoleColor.Gray;
        while (time >= 1)
        {
            Console.CursorVisible = false;
            Console.WriteLine(time);
            Thread.Sleep(1000);
            time -= 1;
            int cursor = Console.GetCursorPosition().Top;
            Console.SetCursorPosition(0, cursor - 1);
        }
        Console.CursorVisible = true;
    }

    public static void PlayAgain()
    {
        Console.WriteLine("\nVill du spela igen? Y/N");
    }

    public static bool PlayerIsHuman()
    {
        Console.Write("\nVill du spela mot datorn? Y/N");
        char PlayerIsComputer = char.ToLower(Console.ReadKey().KeyChar);
        if (PlayerIsComputer == 'y')
        {
            return false;
        }
        else if (PlayerIsComputer == 'n')
        {
            return true;
        }
        else
        {
            Console.WriteLine("\nFelaktig inmatning. Spelare två satt till dator");
            Thread.Sleep(2000);
            return false;
        }
    }
}
