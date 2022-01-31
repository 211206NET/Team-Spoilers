namespace Models;
using System.Data;

public class Player{
    public Player(){}

    public Player(User nPlayer){
        UserID = nPlayer.UserID;
    }

    public Player(DataRow row){
        this.PlayerID = (int) row["PlayerID"];
        this.isMaster = (bool) row["isMaster"];
        this.UserID = (int) row["UserID"];
        this.Score = (int) row["Score"];
    }

    public int PlayerID { get; set; }
    public bool isMaster { get; set; }
    public int UserID { get; set; }
    public int Score { get; set; }

    public void startGame(Player nGamer){
        Game nGame = new Game();
        nGamer.isMaster = true;
        nGamer.Score = 0;
    }

    public void addPoints(Player contestant, BingoCard card){
        if(card.isMarked == true){
            contestant.Score++;
        }
    }
    public override string ToString()
    {
        return $"Player ID: {this.PlayerID} \nMaster? {this.isMaster} \nUser ID: {this.UserID} \nScore: {this.Score}";
    }

    public void ToDataRow(ref DataRow row){
        row["PlayerID"] = (int) this.PlayerID;
        row["isMaster"] = (bool) this.isMaster;
        row["UserID"] = (int) this.UserID;
        row["Score"] = (int) this.Score;
    }
}