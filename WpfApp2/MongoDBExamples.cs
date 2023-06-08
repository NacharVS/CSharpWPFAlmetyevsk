using MongoDB.Driver;

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
    }
}
