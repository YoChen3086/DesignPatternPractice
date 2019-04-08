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

        public override void Use(User user)
        {
            Console.WriteLine($"網站分類: {name}, 用戶: {user.Name}");
        }
    }
}
