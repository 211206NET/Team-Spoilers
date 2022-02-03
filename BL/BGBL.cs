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
    public void DeleteBingoCard(int id){
        _dl.DeleteBingoCard(id);
    }
    public void DeleteGame(int id){
        _dl.DeleteGame(id);
    }
    public void DeleteLeaderboard(int id){
        _dl.DeleteLeaderboard(id);
    }
    public void DeletePlayer(int id){
        _dl.DeletePlayer(id);
    }
    public BingoCard GetBingoCardById(int id){
        return _dl.GetBingoCardById(id);
    }
    public BingoCard AddBingoCard(BingoCard cardToAdd){
        return _dl.AddBingoCard(cardToAdd);
    }
    public void AddAnswerToCard(int cId, Answer nAns){
        _dl.AddAnswerToCard(cId, nAns);
    }
    public User GetUserById(int id){
        return _dl.GetUserById(id);
    }
    public void AddCardToUser(int uId, BingoCard nCard){
        _dl.AddCardToUser(uId, nCard);
    }
    public Player AddPlayer(Player playerToAdd){
        return _dl.AddPlayer(playerToAdd);
    }
    public Player UpdatePlayer(int id, int master){
        return (Player) _dl.Update(master);
    }
    public List<Series> GetAllSeries(){
        return _dl.GetAllSeries();
    }
    public Series GetSeriesById(int id){
        return _dl.GetSeriesById(id);
    }
    public Series GetSeriesByIMDbId(string id){
        return _dl.GetSeriesByIMDbId(id);
    }
    public Series GetSeriesByTitle(string title){
        return _dl.GetSeriesByTitle(title);
    }
    public Series AddSeries(Series seriesToAdd){
        return _dl.AddSeries(seriesToAdd);
    }
}