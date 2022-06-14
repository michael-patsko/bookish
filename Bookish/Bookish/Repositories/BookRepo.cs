using Bookish.Models;
using Bookish.Models.Requests;
using Microsoft.EntityFrameworkCore;

namespace Bookish.Repositories
{
    public class BookRepo
    {
        private BookishContext _context = new BookishContext();

        public Book GetBookById(int id)
        {
            return _context.Books.Where(b => b.Id == id).Include(b => b.Authors).Single();
        }

        public List<Book> GetAllBooks()
        {
            return _context.Books.Include(b => b.Authors).Include(b => b.Genre).ToList();
        }

        public Book CreateBook(CreateBookRequest request)
        {
            Book newBook = new Book
            {
                Title = request.Title,
                CoverImageUrl = request.CoverImageUrl,
                Blurb = request.Blurb,
                YearPublished = request.YearPublished,
                Authors = new List<Author> { },
                Genre = new Genre { }
            };

            Author author = _context.Authors.Where(a => a.Id == request.AuthorId).Single();

            Genre genre = _context.Genres.Where(g => g.Id == request.GenreId).Single();

            newBook.Authors.Add(author);
            newBook.Genre = genre;

            var insertBook = _context.Books.Add(newBook);
            _context.SaveChanges();

            return insertBook.Entity;
        }
    }
}
