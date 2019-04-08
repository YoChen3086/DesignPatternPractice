﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public class ConcreteVisitor2 : Visitor
    {
        public override void VisitConcreteElementA(ConcreteElementA concreteElementA)
        {
            Console.WriteLine($"{concreteElementA.GetType().Name}被{this.GetType().Name}存取");
        }

        public override void VisitConcreteElementB(ConcreteElementB concreteElementB)
        {
            Console.WriteLine($"{concreteElementB.GetType().Name}被{this.GetType().Name}存取");
        }
    }
}
