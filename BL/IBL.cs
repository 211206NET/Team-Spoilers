namespace BL;

public interface IBL
{
    List<User> GetAllUsers();
    User AddUser (User userToAdd);
    List<Answer> GetAnswersbyBingoCardId(int bingoCardID);
    Answer AddAnswer (int bingoCardID, Answer answerToAdd);
    List<BingoCard> GetAllBingoCards();
}