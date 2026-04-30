
using global::Student_Management_System.Models;
using Microsoft.EntityFrameworkCore;
using Student_Management_System.Models;

namespace Student_Management_System.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext
            (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}
