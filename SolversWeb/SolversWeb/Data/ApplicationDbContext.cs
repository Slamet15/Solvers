using Microsoft.EntityFrameworkCore;
using SolversCore.Models;

namespace SolversWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        { 

        }

        public DbSet<Question> Questions { get; set; }
        public DbSet<Test> Tests { get; set; }
    }
}
