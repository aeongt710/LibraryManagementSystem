using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LibraryManagementSystem.Data;
using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.Pages.Subscribers
{
    public class IndexModel : PageModel
    {
        private readonly LibraryManagementSystem.Data.LibraryManagementSystemContext _context;

        public IndexModel(LibraryManagementSystem.Data.LibraryManagementSystemContext context)
        {
            _context = context;
        }

        public IList<Subscriber> Subscriber { get;set; }

        public async Task OnGetAsync()
        {
            Subscriber = await _context.Subscriber.ToListAsync();
        }
    }
}
