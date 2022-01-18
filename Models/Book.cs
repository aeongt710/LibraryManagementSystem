using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    public class Book
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int IBSN { get; set; }

        public string Author { get; set; }

        public int Volume { get; set; }

        public string Description { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}
