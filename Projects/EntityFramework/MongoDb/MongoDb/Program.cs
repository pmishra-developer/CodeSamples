using MongoDB.Bson;
using MongoDB.Driver;

namespace MongoDb;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        
        using(MongoDbContext context = new MongoDbContext())
        {
            context.Users.InsertOne(new User { name = "Pankaj Mishra" });
            context.Users.InsertOne(new User { name = "Ashish Mishra" });
            context.Users.InsertOne(new User { name = "Garima Mishra" });
            context.Users.InsertOne(new User { name = "Sunidhi Mishra" });
    
            var users = context.Users.Find(new BsonDocument()).ToList();
    
            foreach(var user in users)
            {
                Console.WriteLine(user.name);
            }
        }

        Console.ReadLine();
    }
}