using Microsoft.EntityFrameworkCore;

namespace DL;

public class EFRepo : IRepo
{
    private BGDBContext _context;

    public EFRepo(DbContext context)
    {
        _context = (BGDBContext) context;
    }

    public Answer AddAnswer(int bingoCardID, Answer answerToAdd)
    {
        _context.Add(answerToAdd);
        _context.SaveChanges();
        _context.ChangeTracker.Clear();
        return answerToAdd;
    }

    public User AddUser(User userToAdd)
    {
        _context.Add(userToAdd);
        _context.SaveChanges();
        _context.ChangeTracker.Clear();
        return userToAdd;
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

    public List<Answer> GetAnswersbyBingoCardId(int bingoCardID)
    {
        return _context.Answers.Where(r => r.BingoCardID == bingoCardID).ToList();
    }
}