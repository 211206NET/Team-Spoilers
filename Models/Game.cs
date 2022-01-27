namespace Models;

public class Game{
    public Game(){}

    public int GameID { get; set; }
    public string Question { get; set; }
    public int SeriesID { get; set; }
    public int PlayerID { get; set; }
    public bool hasWinner { get; set; }
}