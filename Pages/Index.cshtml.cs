using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Pages
{
    public class IndexModel : PageModel
    {

        public int BooksCount { get; set; }

        public int SubCount { get; set; }

        private readonly ILogger<IndexModel> _logger;
        private readonly LibraryManagementSystem.Data.LibraryManagementSystemContext _context;
        public IndexModel(ILogger<IndexModel> logger, LibraryManagementSystem.Data.LibraryManagementSystemContext context)
        {
            _logger = logger;
            _context = context;
        }

        public void OnGet()
        {
            BooksCount =  _context.Book.ToList().Count();
            SubCount = _context.Subscriber.ToList().Count();
        }
    }
}
