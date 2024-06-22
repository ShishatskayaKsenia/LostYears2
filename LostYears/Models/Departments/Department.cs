
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostYears.Models
{
    [Table("Departments")]
    public class Department
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string ImagePath { get; set; }
        public string Description { get; set; }
        public int Instrument_ID { get; set; }

        [ForeignKey("Instrument_ID")]
        public virtual Instrument Instrument { get; set; }

        public ICollection<Teacher> Teachers { get; set; }
        public ICollection<Class> Classes { get; set; }
        public ICollection<Student> Students { get; set; }
        public ICollection<ChildrenEntry> ChildrenEntries { get; set; }
    }
}
