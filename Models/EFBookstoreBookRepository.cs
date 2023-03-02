using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission9.Models
{
    public class EFBookstoreBookRepository : IBookstoreBookRepository
    {
        private BookstoreBookContext context { get; set; }

        public EFBookstoreBookRepository (BookstoreBookContext temp)
        {
            context = temp;
        }
        public IQueryable<Book> Books => context.Books;
    }
}
