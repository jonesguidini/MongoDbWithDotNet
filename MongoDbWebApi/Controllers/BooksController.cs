using Microsoft.AspNetCore.Mvc;
using MongoDbWebApi.Core;
using MongoDbWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoDbWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public IActionResult GetBooks()
        {
            return Ok(_bookService.GetBooks());
        }

        [HttpGet("{id}", Name = "GetBookById")]
        public IActionResult GetBookById(string id)
        {
            return Ok(_bookService.GetBookById(id));
        }

        [HttpPost]
        public IActionResult AddBook(Book book)
        {
            _bookService.AddBook(book);
            return CreatedAtRoute("GetBookById", new { id = book.Id }, book);
        }


        [HttpPut]
        public IActionResult UpdateBook(Book book)
        {
            _bookService.UpdateBook(book);
            return Ok(book);
        }

        [HttpDelete("{id}", Name = "GetBook")]
        public IActionResult DeleteBook(string id)
        {
            _bookService.DeleteBook(id);
            return NoContent();
        }

    }
}
