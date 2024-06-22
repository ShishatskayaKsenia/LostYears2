using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostYears.Models
{
    public class ParentContext : DbContext
    {
        public ParentContext() : base("DefaultConnection") { }
        public DbSet<Parent> Parents { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("your_connection_string_here");
        //}
    }
}
