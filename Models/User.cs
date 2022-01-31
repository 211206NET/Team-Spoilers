using System.Collections.Generic;
using System.Data;

namespace Models;

public class User{
    public User(){}

    public User(DataRow row){
        this.UserID = (int) row["UserID"];
        this.UserName = row["UserName"].ToString() ?? "";
        this.Password = row["Password"].ToString() ?? "";
        this.BingoCards = (List<BingoCard>) row["BingoCards"];
    }
    public int UserID { get; set; }
    public string? UserName { get; set; }
    public string? Password { get; set; }
    public List<BingoCard>? BingoCards { get; set; }

    public void ToDataRow(ref DataRow row){
        row["UserID"] = (int) this.UserID;
        row["UserName"] = (string) this.UserName;
        row["Password"] = (string) this.Password;
        row["BingoCards"] = (List<BingoCard>) this.BingoCards;
    }
}