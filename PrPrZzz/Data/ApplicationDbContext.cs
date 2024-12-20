using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.Extensions.Configuration;

namespace PrPrZzz.Data
{
    public class Employee
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<Process> Processes { get; set; }
    }

    public class Material
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public ICollection<Process> Processes { get; set; }
    }

    public class Product
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public ICollection<Process> Processes { get; set; }
    }

    public class Process
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long MaterialId { get; set; }
        public long EmployeeId { get; set; }
        public long ProductId { get; set; }
        public string Time { get; set; }
        public Material Material { get; set; }
        public Employee Employee { get; set; }
        public Product Product { get; set; }
    }

    public class RepairRequest
    {
        public long Id { get; set; }
        public string DeviceName { get; set; }
        public string WorkType { get; set; }
        public DateTime CompletionTime { get; set; }
    }

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() { }

        public ApplicationDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Material> Materials { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Process> Processes { get; set; }
        public DbSet<RepairRequest> RepairRequests { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Host=aws-0-eu-central-1.pooler.supabase.com;Port=5432;Database=postgres;Username=postgres.azfpxmllywzanltckntr;Password=2005Danil_2005;")
                              .ConfigureWarnings(warnings => warnings.Throw(RelationalEventId.PendingModelChangesWarning));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Process>()
                .HasOne(p => p.Material)
                .WithMany(m => m.Processes)
                .HasForeignKey(p => p.MaterialId);

            modelBuilder.Entity<Process>()
                .HasOne(p => p.Employee)
                .WithMany(e => e.Processes)
                .HasForeignKey(p => p.EmployeeId);

            modelBuilder.Entity<Process>()
                .HasOne(p => p.Product)
                .WithMany(pr => pr.Processes)
                .HasForeignKey(p => p.ProductId);

            modelBuilder.Entity<RepairRequest>()
                .Property(r => r.CompletionTime)
                .HasColumnType("date");
        }

        public void InitializeDatabase()
        {
            try
            {
                Database.Migrate();
                MessageBox.Show("База данных создана или уже существует.", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при создании базы данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

