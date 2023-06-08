using MongoDB.Bson;

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

        public ObjectId id;
        public string Name { get; set; }
        public string Surname { get; set; }
        public string SecondName { get; set; }
        public string Vacancy { get; set; }
    }
}
