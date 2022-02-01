namespace DL;

public class BGRepo{
    public void startGame(Player nGamer){
        Game nGame = new Game();
        nGamer.isMaster = true;
        nGamer.Score = 0;
    }

    // public void addPoints(Player contestant, BingoCard card){
    //     if(card.isMarked == true){
    //         contestant.Score++;
    //     }
    // }
}