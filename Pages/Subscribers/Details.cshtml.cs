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
    public class DetailsModel : PageModel
    {
        private readonly LibraryManagementSystem.Data.LibraryManagementSystemContext _context;

        public DetailsModel(LibraryManagementSystem.Data.LibraryManagementSystemContext context)
        {
            _context = context;
        }

        public Subscriber Subscriber { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Subscriber = await _context.Subscriber.FirstOrDefaultAsync(m => m.Id == id);

            if (Subscriber == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
