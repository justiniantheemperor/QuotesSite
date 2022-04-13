using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuotesSite.Models
{
    public class Quotes
    {
        [Key]
        [Required]
        public int QuoteID { get; set; }
        [Required]
        public string Quote { get; set; }
        [Required]
        public string Author { get; set; }
        //public DateTime Date { get; set; }
        public string Subject { get; set; }
        public string citation { get; set; }
    }
}
