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
}