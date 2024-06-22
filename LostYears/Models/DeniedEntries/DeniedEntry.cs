using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostYears.Models
{
    [Table("DeniedEntries")]
    public class DeniedEntry
    {
        [Key]
        public int ID { get; set; }
        public string ChildName { get; set; }
        public string Reason { get; set; }
        public int Parent { get; set; }
    }
}
