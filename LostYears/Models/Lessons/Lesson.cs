using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostYears.Models
{
    [Table("Lessons")]
    public class Lesson
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
