using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebAppLibraryRP_EF.Data;
using WebAppLibraryRP_EF.Models;

namespace WebAppLibraryRP_EF.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly WebAppLibraryRP_EFContext _context;

        public IndexModel(WebAppLibraryRP_EFContext context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; } = default!;

        public async Task OnGetAsync()
        {
            ViewData["role"] = "admin";
            if (_context.Book != null)
            {
                Book = await _context.Book.ToListAsync();
            }
        }
    }
}
