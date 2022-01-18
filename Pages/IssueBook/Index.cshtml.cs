using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LibraryManagementSystem.Data;
using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.Pages.IssueBook
{
    public class IndexModel : PageModel
    {
        private readonly LibraryManagementSystem.Data.LibraryManagementSystemContext _context;

        public IndexModel(LibraryManagementSystem.Data.LibraryManagementSystemContext context)
        {
            _context = context;
        }

        public IList<Issue> Issue { get;set; }

        public async Task OnGetAsync()
        {
            Issue = await _context.Issue
                .Include(i => i.Book)
                .Include(i => i.Subscriber).ToListAsync();
        }
    }
}
