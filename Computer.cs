class Computer
{
    private static Random rnd = new Random();
    static ShotsLeft shotsLeft = new ShotsLeft();
    private char randomChoice = 'a';
    public char RandomChoice
    {
        get { return randomChoice; }
        set { randomChoice = value; }
    }

    public void ComputerRandomRoll()
    {
        string choices = "ssllbbhhhh";
        int index;

        if (shotsLeft.ShotCount() == 0)
        {
            index = rnd.Next(2, 4);
        }
        else if (shotsLeft.ShotCount() > 0 && shotsLeft.ShotCount() < 3)
        {
            index = rnd.Next(0, 5);
        }
        else
        {
            index = rnd.Next(5, 9);
        }
        RandomChoice = choices[index];
    }
}
