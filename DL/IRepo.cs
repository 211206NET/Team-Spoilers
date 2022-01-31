namespace DL;

public interface IRepo
{
    List<User> GetAllUsers();
    User AddUser (User userToAdd);

    List<BingoCard> GetAllBingoCards();
}