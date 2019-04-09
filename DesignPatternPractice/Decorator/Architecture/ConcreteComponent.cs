using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class ConcreteComponent : Component
    {
        public override void Operation()
        {
            Console.WriteLine("具體物件的操作");
        }
    }
}
