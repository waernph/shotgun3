public class RandomHelper
{
    private static Random _rnd = new Random();

    public static int ComputerRandomInterval24() => _rnd.Next(2, 4);

    public static int ComputerRandomInterval05() => _rnd.Next(0, 5);

    public static int ComputerRandomInterval59() => _rnd.Next(5, 9);
}
