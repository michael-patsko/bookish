using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Bookish.Models;
using Bookish.Models.Requests;

namespace Bookish.Controllers;
using Bookish.Services;

public class BookController : Controller
{
    private readonly ILogger<BookController> _logger;
    private BookService _bookService;
    public BookController(ILogger<BookController> logger)
    {
        _logger = logger;
        _bookService = new BookService();

    }

    public IActionResult Index()
    {
        List<Book> books = _bookService.GetAllBooks();
        return View(books);
    }

    [HttpPost("/Book/Create")]
    public IActionResult CreateBook([FromBody] CreateBookRequest request) { 
        Book book = _bookService.CreateBook(request);
        return View("Book", book);

    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
