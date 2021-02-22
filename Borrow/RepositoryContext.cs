using Borrow.Models;
using Microsoft.EntityFrameworkCore;

namespace Borrow
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options) { }
        public DbSet<User> Owners { get; set; }
        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
           => optionsBuilder.UseNpgsql("Host=localhost;Database=BorrowApp;Username=postgres;Password=Ciastko2020!");*/
    }

}

