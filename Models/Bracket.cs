using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bracketdocious.Models
{
    public class Bracket
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public int RoundFormat { get; set; }
        public DateTime CreatedAt { get; set; }
        public int Active { get; set; }
    }
}
