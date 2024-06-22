using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostYears.Models
{
    public class Class
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Department_ID { get; set; }
        public int Teacher_ID { get; set; }

        [ForeignKey("Department_ID")]
        public Department Department { get; set; }

        [ForeignKey("Teacher_ID")]
        public Teacher Teacher { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
