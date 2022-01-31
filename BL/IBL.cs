namespace BL;

public interface IBL
{
    List<User> GetAllUsers();
    void AddUser (User userToAdd);
}