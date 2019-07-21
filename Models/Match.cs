using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bracketdocious.Models
{
    public class Match
    {
        [Key]
        public int BracketID { get; set; }
        public DateTime Date { get; set; }
        public int TeamAID { get; set;}
        public int TeamBID { get; set; }
        public string TeamAScore { get; set; }
        public string TeamBScore { get; set; }
        public int MatchType { get; set; }
    }
}
