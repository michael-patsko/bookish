using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Bookish.Models;

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

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
