using ServiceBusAutomation.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace ServiceBusAutomation.Data
{
    public class ServiceBusAutomationContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Bus> Buses { get; set; }
        public ServiceBusAutomationContext(DbContextOptions<ServiceBusAutomationContext> options) : base(options)
        {     
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().ToTable("Employee");
            modelBuilder.Entity<Employee>().HasKey(a => a.EmployeeId);
            base.OnModelCreating(modelBuilder);
        }
    }
}
