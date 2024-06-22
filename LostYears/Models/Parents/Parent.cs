using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostYears.Models
{
    public class Parent
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Middle_Name { get; set; }
        public string Phone { get; set; }
        public string WorkPlace { get; set; }

        public ICollection<Student> Students { get; set; }
        public ICollection<ChildrenEntry> ChildrenEntries { get; set; }

        public override string ToString()
        {
            return $"{Surname} {Name[0]}. {Middle_Name[0]}.";
        }
    }
}
