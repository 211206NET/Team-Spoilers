using Microsoft.EntityFrameworkCore;

namespace DL;

public class EFRepo : IRepo
{
    private BGDBContext _context;

    public EFRepo(DbContext context)
    {
        _context = (BGDBContext) context;
    }

    public Answer AddAnswer(Answer answerToAdd)
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

    public void DeleteUser(string userToDelete){
        _context.Remove(_context.Users.Single(u => u.UserName == userToDelete));
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

    public List<Answer> GetAnswersbyBingoCardId(int bingoCardID)
    {
        return _context.Answers.Where(r => r.BingoCardID == bingoCardID).ToList();
    }

    public List<BingoCard> GetBingoCardsbyUserId(int userID)
    {
        return _context.BingoCards.Where(r => r.UserID == userID).ToList();
    }

    public List<Player> GetPlayersByUserId(int userID){
        return _context.Players.Where(r => r.UserID == userID).ToList();
    }

    public object Update(object entity)
    {
        _context.Entry(entity).State = EntityState.Modified;
        _context.SaveChanges();
        _context.ChangeTracker.Clear();
        return entity;
    }
}