using System.Collections.Generic;

namespace Models;
using System.Data;

public class BingoCard{
    public BingoCard(){}

    public int ID { get; set; }
    public int SeriesID { get; set; }
    public int UserID { get; set; }
    public int GameID { get; set; }
    public List<Answer> Answers { get; set; }
}