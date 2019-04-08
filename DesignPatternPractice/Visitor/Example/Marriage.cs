using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public class Marriage : Action
    {
        public override void GetManConclusion(Man concreteElementA)
        {
            Console.WriteLine($"{concreteElementA.GetType().Name}{this.GetType().Name}時，感慨道:戀愛遊戲終結時，有妻徒刑，遙無期。");
        }

        public override void GetWomanConclusion(Woman concreteElementB)
        {
            Console.WriteLine($"{concreteElementB.GetType().Name}{this.GetType().Name}時，新位約:愛情長跑路漫漫，婚姻保險保平安。");
        }
    }
}
