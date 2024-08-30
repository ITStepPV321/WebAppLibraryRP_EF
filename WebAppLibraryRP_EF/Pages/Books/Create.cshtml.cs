using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebAppLibraryRP_EF.Data;
using WebAppLibraryRP_EF.Models;

namespace WebAppLibraryRP_EF.Pages.Books
{
    public class CreateModel : PageModel
    {
        private readonly WebAppLibraryRP_EF.Data.WebAppLibraryRP_EFContext _context;

        public CreateModel(WebAppLibraryRP_EF.Data.WebAppLibraryRP_EFContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Book Book { get; set; } = default!;

        static private readonly List<string> listStyle = new () { "Fantazy", "Drama", "Thriller", "Comedy" };
        public SelectList StylesBook { get; set; } = new SelectList(listStyle);


        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid || _context.Book == null || Book == null)
            {
                return Page();
            }

            _context.Book.Add(Book);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
