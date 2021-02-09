using MongoDB.Driver;
using MongoDbWebApi.Models;

namespace MongoDbWebApi.Core
{
    public interface IDbClient
    {
        IMongoCollection<Book> GetBooksCollection();
    }
}
