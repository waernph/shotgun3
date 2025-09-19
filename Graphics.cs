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

    /* public static void NotValidInput(int choice)
    {
        choice -= 100;
        string[] errorMessage =
        [
            "Du har inga skott, försök inte!",
            "Valet finns inte. Försök igen",
            "Du måste ha minst 3 skott",
        ];
        //Console.WriteLine(choice);
        Console.WriteLine(errorMessage[choice]);
    } */
}
