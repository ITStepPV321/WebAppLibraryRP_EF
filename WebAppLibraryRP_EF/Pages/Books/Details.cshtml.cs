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
    public class DetailsModel : PageModel
    {
        private readonly WebAppLibraryRP_EF.Data.WebAppLibraryRP_EFContext _context;

        public DetailsModel(WebAppLibraryRP_EF.Data.WebAppLibraryRP_EFContext context)
        {
            _context = context;
        }

      public Book Book { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Book == null)
            {
                return NotFound();
            }

            var book = await _context.Book.FirstOrDefaultAsync(m => m.Id == id);
            if (book == null)
            {
                return NotFound();
            }
            else 
            {
                Book = book;
            }
            return Page();
        }
    }
}
