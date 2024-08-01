using ServiceBusAutomation.Models;
using Microsoft.EntityFrameworkCore;

namespace ServiceBusAutomation.Data
{
    public class ServiceBusAutomationContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=SQLEXPRESS;Database=ServiceDb;Trusted_Connection=True;TrustServerCertificate=True;");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().ToTable("tb_Employee");
            modelBuilder.Entity<Employee>().HasKey(a => a.EmployeeId);
            base.OnModelCreating(modelBuilder);
        }
    }
}
