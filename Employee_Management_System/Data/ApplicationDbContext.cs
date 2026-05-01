
using Employee_Management_System.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace Employee_Management_System.Data
{
    public class ApplicationDbContext : DbContext 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
            public DbSet<Employee> Employees { get; set; }
            public DbSet<User>  Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .Property(e => e.Salary)
                .HasPrecision(18, 2); // total digits, decimal places
        }

    }
}
