namespace DL;

public interface IRepo
{
    List<User> GetAllUsers();
    User AddUser (User userToAdd);

    void DeleteUser(string userToDelete);
    List<BingoCard> GetAllBingoCards();

    List<Answer> GetAnswersbyBingoCardId(int bingoCardID);
    Answer AddAnswer (Answer answerToAdd);
    List<BingoCard> GetBingoCardsbyUserId(int userID);
    List<Player> GetPlayersByUserId(int userID);
    BingoCard GetBingoCardById(int id);
    User GetUserById(int id);
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
    void AddAnswerToCard(int cId, Answer nAns);
}