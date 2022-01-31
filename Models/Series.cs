namespace Models;

public class Series{
    public Series(){}

    public int SeriesID { get; set; }
    public string? Name { get; set; }
    public string? Genre { get; set; }
    public string? IMDbID { get; set; }
    public int LeaderboardID { get; set; }
}