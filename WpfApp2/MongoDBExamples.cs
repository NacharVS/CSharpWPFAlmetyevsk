using MongoDB.Driver;
using System.Collections.Generic;

namespace WpfApp2
{
    internal class MongoDBExamples
    {

        public static void CreateDocument(User user)
        {
            var mongoClient = new MongoClient("mongodb://localhost");
            var database = mongoClient.GetDatabase("TestDatabase");
            var collection = database.GetCollection<User>("Users");
            collection.InsertOne(user);
        }

        public static List<User> FindAllDocument()
        {
            var mongoClient = new MongoClient("mongodb://localhost");
            var database = mongoClient.GetDatabase("TestDatabase");
            var collection = database.GetCollection<User>("Users");
            var users = collection.Find(x => true).ToList();
            return users;           
        }

        public static User? FindDocument(string name)
        {
            var mongoClient = new MongoClient("mongodb://localhost");
            var database = mongoClient.GetDatabase("TestDatabase");
            var collection = database.GetCollection<User>("Users");
            var users = collection.Find(x => x.Name == name).FirstOrDefault();
            return users;
        }
    }
}
