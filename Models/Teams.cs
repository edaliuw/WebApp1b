using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bracketdocious.Models
{
    public class Teams
    {
        [Key]
        public int teamID { get; set; }
        public int bracketID { get; set; }
    }
}
