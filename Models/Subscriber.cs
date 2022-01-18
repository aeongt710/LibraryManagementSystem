using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    public class Subscriber
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Display(Name= "Registration Number")]
        [Required]
        public string RegistrationNumber { get; set; }
        public int Age { get; set; }

        [Display(Name = "Cell Number")]
        public int Number { get; set; }
    }
}
