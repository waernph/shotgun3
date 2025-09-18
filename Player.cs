class Player
{
    private string name = "";
    private bool isHuman = true;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public bool IsHuman
    {
        get { return isHuman; }
        set { isHuman = value; }
    }

    ShotsLeft shotsLeft = new ShotsLeft();


}
