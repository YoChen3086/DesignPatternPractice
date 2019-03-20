using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class Person
    {
        private string name;

        public Person(string name)
        {
            this.name = name;
        }

        public void WearTShirts()
        {
            Console.Write("大T恤 ");
        }

        public void WearBigTrouser()
        {
            Console.Write("垮褲 ");
        }

        public void WearSneakers()
        {
            Console.Write("破球鞋 ");
        }

        public void WearSuit()
        {
            Console.Write("西裝 ");
        }

        public void WearTie()
        {
            Console.Write("領帶 ");
        }

        public void WearLeatherShoes()
        {
            Console.Write("皮鞋 ");
        }

        public void Show()
        {
            Console.Write($"裝扮的{name}");
        }
    }
}
