namespace DL;

public interface IRepo
{
    List<User> GetAllUsers();
    User AddUser (User userToAdd);

    List<BingoCard> GetAllBingoCards();

    List<Answer> GetAnswersbyBingoCardId(int bingoCardID);
    Answer AddAnswer (int bingoCardID, Answer answerToAdd);
}