class RandomHelper
{
    private static Random _rnd = new Random();

    public static int ComputerRandomInterval23() => _rnd.Next(2, 3);

    public static int ComputerRandomInterval05() => _rnd.Next(0, 5);

    public static int ComputerRandomInterval14() => _rnd.Next(1, 4);

    public static int ComputerRandomInterval59() => _rnd.Next(5, 9);

    public static int WinnerRandom12() => _rnd.Next(1, 2);
}
