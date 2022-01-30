namespace Models;

public class Player{
    public Player(){}

    public Player(User nPlayer){
        UserID = nPlayer.UserID;
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
}