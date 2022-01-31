namespace BL;

public interface IBL
{
    List<User> GetAllUsers();
    User AddUser (User userToAdd);
}