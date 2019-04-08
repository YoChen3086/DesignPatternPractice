using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    public class ConcreteWebSite : WebSite
    {
        private string name = "";
        public ConcreteWebSite(string name)
        {
            this.name = name;
        }

        public override void Use()
        {
            Console.WriteLine($"網站分類: {name}");
        }
    }
}
