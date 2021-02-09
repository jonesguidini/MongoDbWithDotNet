using MongoDB.Driver;
using MongoDbWebApi.Models;
using System.Collections.Generic;

namespace MongoDbWebApi.Core
{
    public class BookService : IBookService
    {
        private readonly IMongoCollection<Book> _books;
        public BookService(IDbClient dbClient)
        {
            _books = dbClient.GetBooksCollection();
        }


        public List<Book> GetBooks()
        {
            return _books.Find(book => true).ToList();
        }


        public Book GetBookById(string id)
        {
            return _books.Find(b => b.Id == id).FirstOrDefault();
        }

        

        public Book AddBook(Book book)
        {
            _books.InsertOne(book);
            return book;
        }


        public Book UpdateBook(Book book)
        {
            GetBookById(book.Id);
            _books.ReplaceOne(b => b.Id == book.Id, book);         
            return book;
        }

        public void DeleteBook(string id)
        {
            _books.DeleteOne(b => b.Id == id);
        }
    }
}
