using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using LibraryManagementSystem.Data;
using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.Pages.IssueBook
{
    public class CreateModel : PageModel
    {
        private readonly LibraryManagementSystem.Data.LibraryManagementSystemContext _context;

        public CreateModel(LibraryManagementSystem.Data.LibraryManagementSystemContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["BookId"] = new SelectList(_context.Book, "Id", "Name");
        ViewData["SubscriberId"] = new SelectList(_context.Subscriber, "Id", "Name");
            return Page();
        }

        [BindProperty]
        public Issue Issue { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Issue.Add(Issue);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
