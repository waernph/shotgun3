class Computer
{
    Random rnd = new Random();
    static ShotsLeft shotsLeft = new ShotsLeft();

    /*     private char randomChoice;
        public char RandomChoice
        {
            get { return randomChoice; }
            set { randomChoice = value; }
        } */

    public char ComputerRandomRoll()
    {
        string choices = "ssllbbhhhh";
        int index;

        if (shotsLeft.ShotCount() == 0)
        {
            index = rnd.Next(4, 4);
        }
        else if (shotsLeft.ShotCount() > 0 && shotsLeft.ShotCount() < 3)
        {
            index = rnd.Next(0, 5);
        }
        else
        {
            index = rnd.Next(5, 9);
        }
        return choices[index];
    }
}
