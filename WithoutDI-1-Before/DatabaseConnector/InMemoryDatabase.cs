using System.Collections.Generic;

// ReSharper disable CheckNamespace
namespace DatabaseConnector
// ReSharper restore CheckNamespace
{
    public class InMemoryDatabase
    {
        public List<User> GetUsers()
        {
            return new List<User>
                       {
                           new User("Mark", "Lamley", 19),
                           new User("Mike", "Rose", 15),
                           new User("Lori", "Crepas", 20),
                           new User("Some", "Dude", 30),
                           new User("Sergey", "Sorotkin", 50),
                           new User("Charles", "Vallance", 49),
                       };
        }
    }
}
