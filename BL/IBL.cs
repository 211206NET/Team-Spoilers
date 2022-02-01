namespace BL;

public interface IBL
{
    List<User> GetAllUsers();
    User AddUser (User userToAdd);
    List<Answer> GetAnswersbyBingoCardId(int bingoCardID);
    Answer AddAnswer (Answer answerToAdd);
    List<BingoCard> GetAllBingoCards();
    List<BingoCard> GetBingoCardsbyUserId(int userID);
    Answer UpdateAnswer(int AnswerID, int marked);
}