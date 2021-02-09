using System.Collections.Generic;
using MongoDbWebApi.Models;

namespace MongoDbWebApi.Core
{
    public interface IBookService
    {
        List<Book> GetBooks();
        Book GetBookById(string id);
        Book AddBook(Book book);
        Book UpdateBook(Book book);
        void DeleteBook(string id);
    }
}
