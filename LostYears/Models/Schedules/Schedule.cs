using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostYears.Models
{
    [Table("Schedule")]
    public class Schedule
    { 
        [Key]
        public int ID { get; set; }

        public int Class_ID { get; set; }
        public int Teacher_ID { get; set; }
        public int Lesson_ID { get; set; }

        public TimeSpan start_time { get; set; }
        public TimeSpan end_time { get; set; }
        public DateTime date { get; set; }

        [ForeignKey("Class_ID")]
        public virtual Class Class { get; set; }

        [ForeignKey("Teacher_ID")]
        public virtual Teacher Teacher { get; set; }

        [ForeignKey("Lesson_ID")]
        public virtual Lesson Lessons { get; set; }
    }
}
