using Microsoft.EntityFrameworkCore;

namespace ProducerAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Models.ProducerEnt> Producers { get; set; }
    }
}
