using BookApi.Model;
using BookApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace BookApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        public IActionResult GetBookById(int id)
        {
            var book = _bookService.FindBookById(id);

            return Ok(book);
        }

        public IActionResult GetAllBooks()
        {
            var books = _bookService.FindAllBooks();

            return Ok(books);
        }

        public IActionResult CreateBook(Book book)
        {
            _bookService.CreateBook(book);

            return StatusCode(201);
        }

        public IActionResult UpdateBook(Book book)
        {
            _bookService.UpdateBook(book);

            return StatusCode(200);
        }

        public IActionResult DeleteBook(int id)
        {
            _bookService.DeleteBook(id);

            return StatusCode(200);
        }
    }
}
