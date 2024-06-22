using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostYears.Models
{
    public class SchedulesContext:DbContext
    {
        public SchedulesContext() : base("DefaultContext"){ }
        public DbSet<Schedule> Schedules { get; set;}

        public DbSet<Class> Classes { get; set;}
        public DbSet<Teacher> Teachers { get; set;}
        public DbSet<Lesson> Lessons { get; set;}
    }
}
