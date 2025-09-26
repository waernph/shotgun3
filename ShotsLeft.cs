class ShotsLeft
{
    private int _shots;
    public int Shots
    {
        get { return _shots; }
        private set { _shots = value; }
    }

    public void FireShot()
    {
        Shots -= 1;
    }

    public void LoadShot()
    {
        Shots += 1;
    }
}
