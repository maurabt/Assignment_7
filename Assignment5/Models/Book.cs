using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5.Models
{
    public class Book
    {
        [Key] 
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public long ISBN { get; set; }
        public string Class { get; set; }
        public string Type { get; set; }
        public string Price { get; set; }
        public int Pages { get; set; }

    }
}
