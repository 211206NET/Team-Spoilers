namespace Models;
using System.Data;

public class Leaderboard{
    public Leaderboard(){}

    public Leaderboard(int pID){
        this.PlayerID = pID;
    }

    public Leaderboard(DataRow row){
        this.LeaderboardID = (int) row["LeaderboardID"];
        this.PlayerID = (int) row["PlayerID"];
    }

    public int LeaderboardID { get; set; }
    public int PlayerID { get; set; }

    public void ToDataRow(ref DataRow row){
        row["LeaderboardID"] = (int) this.LeaderboardID;
        row["PlayerID"] = (int) this.PlayerID;
    }
}