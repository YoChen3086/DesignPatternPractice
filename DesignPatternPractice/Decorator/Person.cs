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

        public void Show()
        {
            Console.Write($"裝扮的{name}");
        }
    }
}
