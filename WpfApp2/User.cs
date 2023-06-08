using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace WpfApp2
{
    internal class User
    {
        public User(string name, string surname, string secondName, string vacancy)
        {
            Name = name;
            Surname = surname;
            SecondName = secondName;
            Vacancy = vacancy;
        }

        public User(string name, string surname, string secondName)
        {
            Name = name;
            Surname = surname;
            SecondName = secondName;
        }

        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId id;
        [BsonElement("FirstName")] 
        public string Name { get; set; }
        
        [BsonElement("LastName")]
        public string Surname { get; set; }
        public string SecondName { get; set; }
        [BsonIgnoreIfNull]
        [BsonIgnoreIfDefault]
        public string Vacancy;
    }
}
