using Microsoft.EntityFrameworkCore;

namespace Private_School.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : 
            base(options) {
        
        }
        public DbSet<Student> Students { get; set; }
        //public DbSet<Teacher> Teachers { get; set; }
        //public DbSet<BoardOfDirectories> Board_Of_Directories { get; set; }
        //public DbSet<Employee> Employees { get; set; }
        //public DbSet<Parent> Parents { get; set; }
        //public DbSet<Payment> Payments { get; set; }
        //public DbSet<Enrollment> Enrollments { get; set; }
        //public DbSet<Subject> Subjects { get; set; }
    }
}
