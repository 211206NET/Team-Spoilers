namespace BL;

using System.Collections.Generic;
using Models;

public class BGBL :IBL
{
    private IRepo _dl;

    public BGBL(IRepo repo)
    {
        _dl = repo;
    }
    // private BGRepo _bgr;

    // public void startGame(Player nPlay){
    //     _bgr.startGame(nPlay);
    // }

    // public void addPoints(Player contestant, BingoCard card){
    //     _bgr.addPoints(contestant, card);
    // }

    public List<User> GetAllUsers()
    {
        throw new NotImplementedException();
    }

    public User AddUser(User userToAdd)
    {
        return _dl.AddUser(userToAdd);
    }

    public void DeleteUser(string userToDelete){
        _dl.DeleteUser(userToDelete);
    }

    public List<Answer> GetAnswersbyBingoCardId(int bingoCardID)
    {
        return _dl.GetAnswersbyBingoCardId(bingoCardID);
    }

    public Answer AddAnswer(Answer answerToAdd)
    {
        return _dl.AddAnswer(answerToAdd);
    }

    public List<BingoCard> GetAllBingoCards()
    {
        throw new NotImplementedException();
    }

    public List<BingoCard> GetBingoCardsbyUserId(int userID)
    {
        return _dl.GetBingoCardsbyUserId(userID);
    }

    public List<Player> GetPlayersByUserId(int userID){
        return _dl.GetPlayersByUserId(userID);}

    public Answer UpdateAnswer(int AnswerID, int marked)
    {
        return (Answer) _dl.Update(marked);
    }

    public void Delete(object entity)
    {
        _dl.Delete(entity);
    }
    public Answer GetAnswerbyId(int answerID)
    {
        return _dl.GetAnswerbyId(answerID);
    }

    public bool Login(string username, string password){
        return _dl.Login(username, password);
    }

    public void DeleteSeries(string seriesToDelete){
        _dl.DeleteSeries(seriesToDelete);
    }
}