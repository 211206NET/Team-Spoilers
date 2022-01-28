using Microsoft.EntityFrameworkCore;

namespace DL;

public class BGDBContext : DbContext
{
    public BGDBContext() : base() { }
    public BGDBContext(DbContextOptions options) : base(options) { }

}