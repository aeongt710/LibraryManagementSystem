using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    public class Issue
    {
        public int Id { get; set; }

        public int BookId { get; set; }
        public Book Book { get; set; }

        public int SubscriberId { get; set; }
        public Subscriber Subscriber { get; set; }

        [Display(Name="Issue Date")]
        [DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:YYYY/MM/DD}")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime IssueDate { get; set; }
    }
}
