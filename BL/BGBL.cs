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

    public Answer AddAnswer(int bingoCardID, Answer answerToAdd)
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

    // public Answer UpdateAnswer(int answerID)
    // {
    //     return (Answer) _dl.Update(Answer);
    // }

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
    public BingoCard AddAnswerToCard(int cId, Answer nAns){
        return _dl.AddAnswerToCard(cId, nAns);
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
    public Series GetSeriesByIMDbId(int id){
        return _dl.GetSeriesByIMDbId(id);
    }
    public Series GetSeriesByTitle(string title){
        return _dl.GetSeriesByTitle(title);
    }
    public Series AddSeries(Series seriesToAdd){
        return _dl.AddSeries(seriesToAdd);
    }
    public Series UpdateSeries(int id, int imdb){
        return (Series) _dl.Update(imdb);
    }
    public Game AddGame(Game gameToAdd){
        return _dl.AddGame(gameToAdd);
    }
    public Leaderboard AddLeaderboard(Leaderboard leaderboardToAdd){
        return _dl.AddLeaderboard(leaderboardToAdd);
    }
    public Game GetGameById(int id){
        return _dl.GetGameById(id);
    }
    public Leaderboard GetLeaderboardById(int id){
        return _dl.GetLeaderboardById(id);
    }
    public Game UpdateGame(int id, int winner){
        return (Game) _dl.Update(winner);
    }
    public void AddPlayerToLeaderboard(int lId, int pId){
        _dl.AddPlayerToLeaderboard(lId, pId);
    }
    public List<Game> GetAllGames(){
        return _dl.GetAllGames();
    }

    public object Update(object entity)
    {
        return _dl.Update(entity);
    }
}