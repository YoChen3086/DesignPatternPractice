using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public class Failing : Action
    {
        public override void GetManConclusion(Man concreteElementA)
        {
            Console.WriteLine($"{concreteElementA.GetType().Name}{this.GetType().Name}時，悶頭喝酒，誰也不用勸。");
        }

        public override void GetWomanConclusion(Woman concreteElementB)
        {
            Console.WriteLine($"{concreteElementB.GetType().Name}{this.GetType().Name}時，眼淚汪汪，誰也勸不了。");
        }
    }
}
