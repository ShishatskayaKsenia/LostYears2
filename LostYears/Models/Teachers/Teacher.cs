
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostYears.Models
{
    [Table("Teachers")]
    public class Teacher
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Middle_Name { get; set; }
        public string Phone { get; set; }
        public int Department_ID { get; set; }

        [ForeignKey("Department_ID")]
        public virtual Department Department { get; set; }

        public ICollection<Class> Classes { get; set; }
    }
}
