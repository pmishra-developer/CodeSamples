using MongoDB.Bson;
using MongoDB.EntityFrameworkCore;

namespace MongoDb;

[Collection("Users")]
public class User
{
    public ObjectId _id;
    public string name { get; set; }
}