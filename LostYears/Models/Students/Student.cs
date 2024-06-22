using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostYears.Models
{
    [Table("Student")]
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Middle_Name { get; set; }
        public DateTime BirthDay { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }


        public int Department_ID { get; set; }
        public int Parent_ID { get; set; }
        public int Class_ID { get; set; }


        [ForeignKey("Department_ID")]
        public virtual Department Department { get; set; }

        [ForeignKey("Parent_ID")]
        public virtual Parent Parent { get; set; }

        [ForeignKey("Class_ID")]
        public virtual Class Class { get; set; }
    }
}
