using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("小菜");

            Console.WriteLine("第一種裝扮:");
            Finery tShirts = new TShirts();
            Finery bigTrouser = new BigTrouser();
            Finery sneakers = new Sneakers();
            tShirts.Show();
            bigTrouser.Show();
            sneakers.Show();
            person.Show();

            Console.WriteLine("\n第二種裝扮:");
            Finery suit = new Suit();
            Finery tie = new Tie();
            Finery leatherShoes = new LeatherShoes();
            suit.Show();
            tie.Show();
            leatherShoes.Show();
            person.Show();

            Console.ReadLine();
        }
    }
}
