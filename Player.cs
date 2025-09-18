class Player
{
    private bool isHuman;
    public bool IsHuman { get; set; }
    public Player(bool isHuman)
    {
        IsHuman = isHuman;
    }
    ShotsLeft sl = new ShotsLeft();

    public int DisplayPlayersShots()
    {
        return sl.ShotCount();
    }
}
