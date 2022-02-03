namespace DL;

public interface IRepo
{
    List<User> GetAllUsers();
    User AddUser (User userToAdd);

    void DeleteUser(string userToDelete);
    List<BingoCard> GetAllBingoCards();
    List<Game> GetAllGames();
    List<Answer> GetAnswersbyBingoCardId(int bingoCardID);
    Answer AddAnswer (Answer answerToAdd);
    List<BingoCard> GetBingoCardsbyUserId(int userID);
    List<Player> GetPlayersByUserId(int userID);
    BingoCard GetBingoCardById(int id);
    User GetUserById(int id);
    List<Series> GetAllSeries();
    Series GetSeriesById(int id);
    Series GetSeriesByIMDbId(int id);
    Series GetSeriesByTitle(string title);
    object Update(object entity);
    void Delete(object entity);
    Answer GetAnswerbyId(int answerID);
    bool Login(string username, string password);
    void DeleteSeries(string seriesToDelete);
    void DeleteBingoCard(int id);
    void DeleteGame(int id);
    void DeleteLeaderboard(int id);
    void DeletePlayer(int id);
    BingoCard AddBingoCard(BingoCard cardToAdd);
    Series AddSeries(Series seriesToAdd);
    void AddAnswerToCard(int cId, Answer nAns);
    void AddCardToUser(int uId, BingoCard nCard);
    void AddPlayerToLeaderboard(int lId, int pId);
    Player AddPlayer(Player playerToAdd);
    Game AddGame(Game gameToAdd);
    Leaderboard AddLeaderboard(Leaderboard leaderboardToAdd);
    Game GetGameById(int id);
    Leaderboard GetLeaderboardById(int id);
}