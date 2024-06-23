using LibraryERP.DataBase.Entity;
using Microsoft.EntityFrameworkCore;

namespace LibraryERP.DataBase
{
    public class LibraryDbContext : DbContext
    {
        protected readonly IConfiguration _configuration;

        public LibraryDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseNpgsql(_configuration.GetConnectionString("LibraryDatabase"));
        }

        public DbSet<BookModel> Books { get; set; }
        public DbSet<UserModel> Users { get; set; }
	}
}
