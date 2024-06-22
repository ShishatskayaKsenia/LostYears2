using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostYears.Models
{
    public class LessonsContext: DbContext
    {
        public LessonsContext(): base("DefaultConnection") { }
        public DbSet<Lesson> Lessons { get;set; }
    }
}
