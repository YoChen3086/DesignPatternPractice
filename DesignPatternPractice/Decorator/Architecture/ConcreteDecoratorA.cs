using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class ConcreteDecoratorA : Decorator
    {
        // 本類別的特有功能，以有別於ConcreateDecoratorB
        private string addedState;

        public override void Operation()
        {
            base.Operation();
            addedState = "New State";
            Console.WriteLine("具體裝飾物件A的操作");
        }
    }
}
