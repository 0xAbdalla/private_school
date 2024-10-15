using Microsoft.EntityFrameworkCore;

namespace Private_School.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<students> Students { get; set; }
        public DbSet<teachers> Teachers { get; set; }
        public DbSet<board_of_directories> Board_Of_Directories { get; set; }
        public DbSet<employees> Employees { get; set; }
        public DbSet<parents> Parents { get; set; }
        public DbSet<payments> Payments { get; set; }
        public DbSet<enrollments> Enrollments { get; set; }
        public DbSet<subjects> Subjects { get; set; }



    }
}
