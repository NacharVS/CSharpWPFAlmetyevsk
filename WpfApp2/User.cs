using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public string Name { get; set; }
        public string Surname { get; set; }
        public string SecondName { get; set; }
        public string Vacancy { get; set; }
    }
}
