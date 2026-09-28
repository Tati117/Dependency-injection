using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyLibrary.Application.DTOs;
using MyLibrary.Application.Services;
using MyLibrary.Application.Services.Interfaces;

namespace MyLibrary.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        public IBooksService bookService;

        public BooksController(IBooksService bookService)
        {
            this.bookService = bookService;
        }

        [HttpPost]
        public IActionResult AddBook([FromBody] BookDTO bookDto)
        {
            var book = bookService.AddBook(bookDto);
            return Ok(book);
        }

        [HttpGet]
        public IActionResult GetBooks()
        {
           return Ok(bookService.GetBooks());   
        }
    }
}
