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
            sneakers.Decorate(person);
            bigTrouser.Decorate(sneakers);
            tShirts.Decorate(bigTrouser);
            tShirts.Show();

            Console.WriteLine("\n第二種裝扮:");
            Finery suit = new Suit();
            Finery tie = new Tie();
            Finery leatherShoes = new LeatherShoes();
            suit.Decorate(person);
            tie.Decorate(suit);
            leatherShoes.Decorate(tie);
            leatherShoes.Show();

            Console.WriteLine("\n");

            Component component = new ConcreteComponent();
            Decorator decoratorA = new ConcreteDecoratorA();
            Decorator decoratorB = new ConcreteDecoratorB();

            decoratorA.SetComponent(component);
            decoratorB.SetComponent(decoratorA);
            decoratorB.Operation();

            Console.ReadLine();
        }
    }
}
