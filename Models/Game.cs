namespace Models;
using System.Data;

public class Game{
    public Game(){}

    public Game(DataRow row){
        this.GameID = (int) row["GameID"];
        this.Question = row["Question"].ToString() ?? "";
        this.SeriesID = (int) row["SeriesID"];
        this.PlayerID = (int) row["PlayerID"];
        this.hasWinner = (bool) row["hasWinner"];
    }
    public int GameID { get; set; }
    public string? Question { get; set; }
    public int SeriesID { get; set; }
    public int PlayerID { get; set; }
    public bool hasWinner { get; set; }

    public void ToDataRow(ref DataRow row){
        row["GameID"] = (int) this.GameID;
        row["Question"] = (string) this.Question;
        row["SeriesID"] = (int) this.SeriesID;
        row["PlayerID"] = (int) this.PlayerID;
        row["hasWinner"] = (bool) this.hasWinner;
    }
}