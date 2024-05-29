using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using ShareBill.Models;

namespace ShareBill.AppDataContext
{

    // TodoDbContext class inherits from DbContext
    public class TodoDbContext(IOptions<DbSettings> dbSettings) : DbContext
    {

        // DbSettings field to store the connection string
        private readonly DbSettings _dbsettings = dbSettings.Value;


        // DbSet property to represent the Todo table
        public DbSet<Todo> Todos { get; set; }

        // Configuring the database provider and connection string

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_dbsettings.ConnectionString);
        }

        // Configuring the model for the Todo entity
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Todo>()
                .ToTable("TodoAPI")
                .HasKey(x => x.Id);
        }
    }
}