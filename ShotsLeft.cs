class ShotsLeft
{
    private int _shots;
    public int Shots
    {
        get { return _shots; }
        private set { _shots = value; }
    }

    public void AddOrSubtractShot(char userInput)
    {
        if (userInput == 's')
        {
            Shots -= 1;
        }
        else if (userInput == 'l')
        {
            Shots += 1;
        }
    }
}
