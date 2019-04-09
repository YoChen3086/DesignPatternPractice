using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class ConcreteDecoratorB : Decorator
    {
        public override void Operation()
        {
            base.Operation();
            AddedBehavior();
            Console.WriteLine("具體裝飾物件B的操作");
        }

        private void AddedBehavior()
        { }
    }
}
