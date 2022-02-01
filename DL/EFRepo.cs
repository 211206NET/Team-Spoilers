using Microsoft.EntityFrameworkCore;

namespace DL;

public class EFRepo : IRepo
{
    private BGDBContext _context;

    public EFRepo(DbContext context)
    {
        _context = (BGDBContext) context;
    }
    public void AddUser(User userToAdd)
    {
        _context.Add(userToAdd);
        _context.SaveChanges();
        _context.ChangeTracker.Clear();
    }

    public List<BingoCard> GetAllBingoCards()
    {
        throw new NotImplementedException();
    }

    public List<User> GetAllUsers()
    {
        List<User> allUsers =_context.Users.Select(r => r).ToList();
        return allUsers;
    }
    public User GetUserByID(int usId){
        List<User> allUsers = GetAllUsers();
        foreach(User us in allUsers){
            if(us.UserID == usId){
                return us;
            }
        }
        return new User();
    }
    public void startGame(){}
    public void addPoints(){}
}