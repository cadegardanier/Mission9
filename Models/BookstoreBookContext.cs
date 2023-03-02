using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Mission9.Models
{
    public class BookstoreBookContext : DbContext
    {
        public BookstoreBookContext()
        {
        }

        public BookstoreBookContext(DbContextOptions<BookstoreBookContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }

    }
}
