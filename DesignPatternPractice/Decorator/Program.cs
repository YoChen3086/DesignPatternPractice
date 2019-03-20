using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("小菜");

            Console.WriteLine("第一種裝扮:");
            person.WearTShirts();
            person.WearBigTrouser();
            person.WearSneakers();
            person.Show();

            Console.WriteLine("\n第二種裝扮:");
            person.WearSuit();
            person.WearTie();
            person.WearLeatherShoes();
            person.Show();

            Console.ReadLine();
        }
    }
}
