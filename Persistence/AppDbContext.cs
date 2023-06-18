using Microsoft.EntityFrameworkCore;
using Persistence.Entities;

namespace Persistence;

public class AppDbContext : DbContext
{
    public DbSet<Author> Authors { get; set; }
    public DbSet<Book> Books { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
            .UseNpgsql("host=127.0.0.1;port=6172;database=db;username=root;password=12345");
    }
}