namespace Models;
using System.Data;

public class Series{
    public Series(){}

    public Series(DataRow row){
        this.SeriesID = (int) row["SeriesID"];
        this.Name = row["Name"].ToString() ?? "";
        this.Genre = row["Genre"].ToString() ?? "";
        this.IMDbID = (int) row["IMDbID"];
        this.LeaderboardID = (int) row["LeaderboardID"];
    }

    public int SeriesID { get; set; }
    public string? Name { get; set; }
    public string? Genre { get; set; }
    public int IMDbID { get; set; }
    public int LeaderboardID { get; set; }

    public void ToDataRow(ref DataRow row){
        row["SeriesID"] = (int) this.SeriesID;
        row["Name"] = (string) this.Name;
        row["Genre"] = (string) this.Genre;
        row["IMDbID"] = (int) this.IMDbID;
        row["LeaderboardID"] = (int) this.LeaderboardID;
    }
}