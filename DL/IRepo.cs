namespace DL;

public interface IRepo
{
    List<User> GetAllUsers();
    void AddUser (User userToAdd);

    List<BingoCard> GetAllBingoCards();
    void startGame();
    void addPoints();
    User GetUserByID(int usId);
}