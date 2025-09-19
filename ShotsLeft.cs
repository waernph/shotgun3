class ShotsLeft
{
    private int shots;
    private int Shots
    {
        get { return shots; }
        set { shots = value; }
    }

    public void FireShot()
    {
        Shots -= 1;
    }

    public void LoadShot()
    {
        Shots += 1;
    }

    public int ShotCount()
    {
        return Shots;
    }
}
