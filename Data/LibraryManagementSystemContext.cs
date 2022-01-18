using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.Data
{
    public class LibraryManagementSystemContext : DbContext
    {
        public LibraryManagementSystemContext (DbContextOptions<LibraryManagementSystemContext> options)
            : base(options)
        {
        }

        public DbSet<LibraryManagementSystem.Models.Book> Book { get; set; }

        public DbSet<LibraryManagementSystem.Models.Subscriber> Subscriber { get; set; }

        public DbSet<LibraryManagementSystem.Models.Category> Category { get; set; }

        public DbSet<LibraryManagementSystem.Models.Issue> Issue { get; set; }
    }
}
