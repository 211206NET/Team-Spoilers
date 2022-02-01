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
}