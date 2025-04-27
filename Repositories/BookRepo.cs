using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositories.Entities;

namespace Repositories
{
    internal class BookRepo
    {
        private DbdesignQlchBansachContext _context;

        public List<Book> GetBook()
        {
            _context = new();
            return _context.Books.ToList();
        }

        public void UpdateBook(Book book)
        {
            _context = new();
            _context.Books.Update(book);
            _context.SaveChanges();
        }
        public void AddBook(Book book)
        {
            _context = new();
            _context.Books.Add(book);
            _context.SaveChanges();
        }
    }
}
