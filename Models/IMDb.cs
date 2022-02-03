namespace Models;
using System.Data;

public class IMDb{
    public IMDb(){}

    public IMDb(DataRow row){
        this.IMDbID = (int) row["IMDbID"];
        this.APIID = (int) row["APIID"];
        this.Name = row["Name"].ToString() ?? "";
        this.Type = row["Type"].ToString() ?? "";
        this.Image = row["Image"].ToString() ??"";
    }
    public int IMDbID { get; set; }
    public int APIID { get; set; }
    public string? Name { get; set; }
    public string? Type { get; set; }
    public string? Image { get; set; }

public void ToDataRow(ref DataRow row){
        row["IMDbID"] = (int) this.IMDbID;
        row["APIID"] = (int) this.APIID;
        row["Name"] = (string) this.Name;
        row["Type"] = (string) this.Type;
        row["Image"] = (string) this.Image;
    }

}