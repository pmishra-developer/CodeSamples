using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;

namespace MongoDb;

public class MongoDbContext : DbContext
{
    private readonly IMongoDatabase _database;

    public MongoDbContext()
    {
        var client = new MongoClient("mongodb://admin:admin@localhost:27017/");
        _database = client.GetDatabase("CustomerDb");
    }

    public IMongoCollection<User> Users => _database.GetCollection<User>("Users");
}