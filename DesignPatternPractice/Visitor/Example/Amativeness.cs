using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public class Amativeness : Action
    {
        public override void GetManConclusion(Man concreteElementA)
        {
            Console.WriteLine($"{concreteElementA.GetType().Name}{this.GetType().Name}時，凡事不懂也要裝懂。");
        }

        public override void GetWomanConclusion(Woman concreteElementB)
        {
            Console.WriteLine($"{concreteElementB.GetType().Name}{this.GetType().Name}時，遇事懂也裝作不懂。");
        }
    }
}
