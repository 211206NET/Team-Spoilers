namespace BL;
using DL;
using Models;

public class BGBL{
    private BGRepo _bgr;

    public void startGame(Player nPlay){
        _bgr.startGame(nPlay);
    }

    public void addPoints(Player contestant, BingoCard card){
        _bgr.addPoints(contestant, card);
    }
}