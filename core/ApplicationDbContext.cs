using Microsoft.EntityFrameworkCore;

namespace PaybackTimeApi.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // public DbSet<TodoItem> TodoItems { get; set; }
    }
}
