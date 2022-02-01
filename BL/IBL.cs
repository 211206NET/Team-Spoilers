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
    List<Player> GetPlayersByUserId(int userID);
}