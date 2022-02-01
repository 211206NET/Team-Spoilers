using Microsoft.EntityFrameworkCore;

namespace DL;

public class BGDBContext : DbContext
{
    public BGDBContext() : base() { }
    public BGDBContext(DbContextOptions options) : base(options) { }

    public DbSet<BingoCard> BingoCards { get; set; }
    public DbSet<Answer> Answers { get; set; }
    public DbSet<Game> Games { get; set; }
    public DbSet<Leaderboard> Leaderboards { get; set; }
    public DbSet<Player> Players { get; set; }
    public DbSet<Series> Series { get; set; }
    public DbSet<User> Users { get; set; }

}