namespace DL;

public interface IRepo
{
    List<User> GetAllUsers();
    void AddUser (User userToAdd);

    List<BingoCard> GetAllBingoCards();
}