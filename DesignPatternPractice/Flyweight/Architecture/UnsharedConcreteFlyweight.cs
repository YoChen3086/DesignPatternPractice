using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    public class UnsharedConcreteFlyweight : Flyweight
    {
        public override void Operation(int extrinsicstate)
        {
            Console.WriteLine($"不共用的具體Flyweight: {extrinsicstate}");
        }
    }
}
