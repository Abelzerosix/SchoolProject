using Microsoft.EntityFrameworkCore;
using SchoolApp.Data.Models;
using System.Reflection;


namespace SchoolApp.Data
{
    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Student> Students { get; set; } = null!;
        public DbSet<Class> Classes { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Class>()
                .HasMany(c => c.Students)
                .WithOne(s => s.Class)
                .HasForeignKey(s => s.ClassId);

            modelBuilder.Entity<Class>()
                .HasIndex(c => new { c.Name, c.Grade })
                .IsUnique();

            modelBuilder.Entity<Student>()
                .Property(s => s.FirstName)
                .IsRequired();

            modelBuilder.Entity<Student>()
                .Property(s => s.LastName)
                .IsRequired();

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}

