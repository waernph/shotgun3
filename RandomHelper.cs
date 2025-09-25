static class RandomHelper
{
    private static Random rnd = new Random();

    public static int ComputerRandomInterval23()
    {
        return rnd.Next(2, 3);
    }

    public static int ComputerRandomInterval05()
    {
        return rnd.Next(0, 5);
    }

    public static int ComputerRandomInterval14()
    {
        return rnd.Next(1, 4);
    }

    public static int ComputerRandomInterval59()
    {
        return rnd.Next(5, 9);
    }

    public static int WinnerRandom12()
    {
        return rnd.Next(1, 2);
    }
}
