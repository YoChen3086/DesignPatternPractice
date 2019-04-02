using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User(1, "YoChen");
            Department dept = new Department(1, "開發部");

            //IFactory factory = new SqlServerFactory();
            IFactory factory = new AccessFactory();
            IUser userServer = factory.CreateUser();
            IDepartment deptServer = factory.CreateDepartment();

            userServer.Insert(user);
            userServer.GetUser(1);

            Console.WriteLine();

            deptServer.Insert(dept);
            deptServer.GetDepartment(1);

            Console.ReadLine();
        }
    }
}
