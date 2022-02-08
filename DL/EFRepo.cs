using Microsoft.EntityFrameworkCore;

namespace DL;

public class EFRepo : IRepo
{
    private BGDBContext _context;

    public EFRepo(DbContext context)
    {
        _context = (BGDBContext) context;
    }

    public Answer AddAnswer(Answer answerToAdd)
    {
        _context.Add(answerToAdd);
        _context.SaveChanges();
        _context.ChangeTracker.Clear();
        return answerToAdd;
    }

    public User AddUser(User userToAdd)
    {
        _context.Add(userToAdd);
        _context.SaveChanges();
        _context.ChangeTracker.Clear();
        return userToAdd;
    }

    public void Delete(object entity)
    {
        _context.Remove(entity);
        _context.SaveChanges();
        _context.ChangeTracker.Clear();
    }

    public void DeleteUser(string userToDelete){
        Delete(_context.Users.Single(u => u.UserName == userToDelete));
    }

    public void DeleteSeries(string seriesToDelete){
        Delete(_context.Series.Single(u => u.Name == seriesToDelete));
    }

    public void DeleteBingoCard(int id){
        Delete(_context.BingoCards.Single(u => u.ID == id));
    }

    public void DeleteGame(int id){
        Delete(_context.Games.Single(u => u.GameID == id));
    }

    public void DeleteLeaderboard(int id){
        Delete(_context.Leaderboards.Single(u => u.LeaderboardID == id));
    }

    public void DeletePlayer(int id){
        Delete(_context.Players.Single(u => u.UserID == id));
    }

    public List<BingoCard> GetAllBingoCards()
    {
        throw new NotImplementedException();
    }

    public List<User> GetAllUsers()
    {
        List<User> allUsers =_context.Users.Select(r => r).ToList();
        return allUsers;
    }

    public List<Game> GetAllGames(){
        List<Game> allGames = _context.Games.Select(g => g).ToList();
        return allGames;
    }
    public List<Player> GetAllPlayers(){
        List<Player> allPlayers = _context.Players.Select(p => p).ToList();
        return allPlayers;
    }
    public List<Answer> GetAllAnswers(){
        List<Answer> allAnswers = _context.Answers.Select(a => a).ToList();
        return allAnswers;
    }

    public Answer GetAnswerbyId(int answerID)
    {
        List<Answer> answer = _context.Answers.Where(r => r.ID == answerID).ToList();
        return answer[0];
    }

    public List<Answer> GetAnswersbyBingoCardId(int bingoCardID)
    {
        return _context.Answers.Where(r => r.BingoCardID == bingoCardID).ToList();
    }

    public List<BingoCard> GetBingoCardsbyUserId(int userID)
    {
        return _context.BingoCards.Where(r => r.UserID == userID).ToList();
    }

    public List<Player> GetPlayersByUserId(int userID){
        return _context.Players.Where(r => r.UserID == userID).ToList();
    }
    public BingoCard GetBingoCardById(int id){
        List<BingoCard> allCards = _context.BingoCards.Where(b => b.ID == id).ToList();
        return allCards[0];
    }

    public User GetUserById(int id){
        List<User> allUsers = _context.Users.Where(u => u.UserID == id).ToList();
        return allUsers[0];
    }

    public List<Series> GetAllSeries(){
        List<Series> allSeries = _context.Series.Select(s => s).ToList();
        return allSeries;
    }

    public Series GetSeriesById(int id){
        List<Series> selSeries = _context.Series.Where(s => s.SeriesID == id).ToList();
        return selSeries[0];
    }

    public Series GetSeriesByIMDbId(int id){
        List<Series> selSeries = _context.Series.Where(s => s.IMDbID == id).ToList();
        return selSeries[0];
    }

    public Series GetSeriesByTitle(string title){
        List<Series> selSeries = _context.Series.Where(s => s.Name == title).ToList();
        return selSeries[0];
    }

    public BingoCard AddBingoCard(BingoCard cardToAdd){
        _context.Add(cardToAdd);
        _context.SaveChanges();
        _context.ChangeTracker.Clear();
        return cardToAdd;
    }

    public Series AddSeries(Series seriesToAdd){
        _context.Add(seriesToAdd);
        _context.SaveChanges();
        _context.ChangeTracker.Clear();
        return seriesToAdd;
    }

    public BingoCard AddAnswerToCard(int cId, Answer nAns){
        BingoCard selCard = _context.BingoCards.Single(c => c.ID == cId);
        selCard.Answers.Add(nAns);
        _context.SaveChanges();
        _context.ChangeTracker.Clear();
        return selCard;
    }

    public void AddCardToUser(int uId, BingoCard nCard){
        User selUser = _context.Users.Single(u => u.UserID == uId);
        selUser.BingoCards.Add(nCard);
        _context.SaveChanges();
        _context.ChangeTracker.Clear();
    }

    public void AddPlayerToLeaderboard(int lId, int pId){
        Leaderboard selLeader = _context.Leaderboards.Single(l => l.LeaderboardID == lId);
        selLeader.PlayerID = pId;
        _context.SaveChanges();
        _context.ChangeTracker.Clear();
    }

    public Player AddPlayer(Player playerToAdd){
        _context.Add(playerToAdd);
        _context.SaveChanges();
        _context.ChangeTracker.Clear();
        return playerToAdd;
    }

    public Game AddGame(Game gameToAdd){
        _context.Add(gameToAdd);
        _context.SaveChanges();
        _context.ChangeTracker.Clear();
        return gameToAdd;
    }

    public Leaderboard AddLeaderboard(Leaderboard leaderboardToAdd){
        _context.Add(leaderboardToAdd);
        _context.SaveChanges();
        _context.ChangeTracker.Clear();
        return leaderboardToAdd;
    }
    public Game GetGameById(int id){
        List<Game> selGame = _context.Games.Where(g => g.GameID == id).ToList();
        return selGame[0];
    }
    public Leaderboard GetLeaderboardById(int id){
        List<Leaderboard> selLeaderboard = _context.Leaderboards.Where(l => l.LeaderboardID == id).ToList();
        return selLeaderboard[0];
    }

    public object Update(object entity)
    {
        _context.Entry(entity).State = EntityState.Modified;
        _context.SaveChanges();
        _context.ChangeTracker.Clear();
        return entity;
    }
//public void Update(int answerID, bool isMarked)
//    {
//        //Update(_context.Answers.Where(a => a.ID == answerID).ToList());
//        //Delete(_context.Users.Single(u => u.UserName == userToDelete));
//        _context.Update();
//        _context.SaveChanges();
//        _context.ChangeTracker.Clear();
//    }
    public bool Login(string username, string password){
        bool doesExist = false;
        List<User> allUsers = GetAllUsers();
        foreach(User user in allUsers){
            if(user.UserName == username){
                if(user.Password == password){
                    doesExist = true;
                }
            }
        }
        return doesExist;
    }

    public List<Leaderboard> GetAllLeaderboards()
    {
        List<Leaderboard> allLeaderboards = _context.Leaderboards.Select(s => s).ToList();
        return allLeaderboards;
    }
}