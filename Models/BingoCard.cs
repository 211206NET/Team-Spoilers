namespace Models;

public class BingoCard{
    public BingoCard(){}

    public int ID { get; set; }
    public int SeriesID { get; set; }
    public int PlayerID { get; set; }
    public int GameID { get; set; }
    public string Answer { get; set;}
    public bool isMarked { get; set; }
}