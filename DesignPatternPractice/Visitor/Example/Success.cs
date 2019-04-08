using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public class Success : Action
    {
        public override void GetManConclusion(Man concreteElementA)
        {
            Console.WriteLine($"{concreteElementA.GetType().Name}{this.GetType().Name}時，背後多半有一個偉大的女人。");
        }

        public override void GetWomanConclusion(Woman concreteElementB)
        {
            Console.WriteLine($"{concreteElementB.GetType().Name}{this.GetType().Name}時，背後大多有一個不成功的男人。");
        }
    }
}
