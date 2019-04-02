using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User(1, "YoChen");

            SqlServerUser sqlServer = new SqlServerUser();

            sqlServer.Insert(user);
            sqlServer.GetUser(1);

            Console.ReadLine();
        }
    }
}
