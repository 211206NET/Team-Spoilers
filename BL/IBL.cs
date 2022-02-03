namespace BL;

public interface IBL
{
    List<User> GetAllUsers();
    User AddUser (User userToAdd);
    void DeleteUser(string userToDelete);
    List<Answer> GetAnswersbyBingoCardId(int bingoCardID);
    Answer AddAnswer (Answer answerToAdd);
    List<BingoCard> GetAllBingoCards();
    List<BingoCard> GetBingoCardsbyUserId(int userID);
    Answer UpdateAnswer(int AnswerID, int marked);
    List<Player> GetPlayersByUserId(int userID);
    void Delete(object entity);
    Answer GetAnswerbyId(int answerID);
    bool Login(string username, string password);
    void DeleteSeries(string seriesToDelete);
    void DeleteBingoCard(int id);
    void DeleteGame(int id);
    void DeleteLeaderboard(int id);
    void DeletePlayer(int id);
    BingoCard GetBingoCardById(int id);
    BingoCard AddBingoCard(BingoCard cardToAdd);
    void AddAnswerToCard(int cId, Answer nAns);
    User GetUserById(int id);
    void AddCardToUser(int uId, BingoCard nCard);
    Player AddPlayer(Player playerToAdd);
    Player UpdatePlayer(int id, int master);
    List<Series> GetAllSeries();
    Series GetSeriesById(int id);
    Series GetSeriesByIMDbId(int id);
    Series GetSeriesByTitle(string title);
    Series AddSeries(Series seriesToAdd);
    Series UpdateSeries(int id, int imdb);
    Game AddGame(Game gameToAdd);
    Leaderboard AddLeaderboard(Leaderboard leaderboardToAdd);
    Game GetGameById(int id);
    Leaderboard GetLeaderboardById(int id);
    Game UpdateGame(int id, int winner);
    void AddPlayerToLeaderboard(int lId, int pId);
    List<Game> GetAllGames();
}