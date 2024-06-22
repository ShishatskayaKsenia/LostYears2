using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostYears.Models
{
    public class AdminsContext:DbContext
    {
        public AdminsContext() : base("DefaultConnection") { }
        public DbSet<Admin> Admins { get; set; }
    }
}
