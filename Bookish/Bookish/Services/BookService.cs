using Bookish.Repositories;
using Bookish.Models;

namespace Bookish.Services
{
    public class BookService
    {
        private BookRepo _bookRepo = new BookRepo();

        public Book GetBookById(int id)
        {
            return _bookRepo.GetBookById(id);
        }

        public List<Book> GetAllBooks()
        {
            return _bookRepo.GetAllBooks();
        }
    }
}