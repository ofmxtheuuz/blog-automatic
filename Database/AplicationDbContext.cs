using BlogOnline.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogOnline.Database;

public class AplicationDbContext : DbContext
{
    public AplicationDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Artigo> Artigos { get; set; }
}