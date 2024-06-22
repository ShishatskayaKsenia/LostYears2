using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostYears.Models
{
    public class StudentContext : DbContext
    {
        public StudentContext() : base("DefaultConnection") { }
        public DbSet<Student> Student { get; set; }


        public DbSet<Department> Departments { get; set; }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<Class> Classes { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Student>()
        //        .HasOne(s => s.Department)
        //        .WithMany(d => d.Students)
        //        .HasForeignKey(s => s.Department_ID);

        //    modelBuilder.Entity<Student>()
        //        .HasOne(s => s.Parent)
        //        .WithMany(p => p.Students)
        //        .HasForeignKey(s => s.Parent_ID);

        //    modelBuilder.Entity<Student>()
        //        .HasOne(s => s.Class)
        //        .WithMany(c => c.Students)
        //        .HasForeignKey(s => s.Class_ID);
        //}

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("your_connection_string_here");
        //}
    }
}
