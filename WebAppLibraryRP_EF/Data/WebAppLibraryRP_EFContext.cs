using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppLibraryRP_EF.Models;

namespace WebAppLibraryRP_EF.Data
{
    public class WebAppLibraryRP_EFContext : DbContext
    {
        public WebAppLibraryRP_EFContext (DbContextOptions<WebAppLibraryRP_EFContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Book { get; set; } = default!;
    }
}
