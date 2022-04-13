using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QuotesSite.Models
{
    public class Quote
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int QuoteId { get; set; }
        [Required]
        public string QuoteText { get; set; }
        [Required]
        public string Author { get; set; }
        public string Date { get; set; }
        public string Subject { get; set; }
        public string Citation { get; set; }
    }
}
