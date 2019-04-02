using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User(1, "YoChen");

            IFactory factory = new SqlServerFactory();
            IUser server = factory.CreateUser();

            server.Insert(user);
            server.GetUser(1);

            Console.ReadLine();
        }
    }
}
