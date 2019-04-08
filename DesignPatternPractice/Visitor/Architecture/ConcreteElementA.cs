using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public class ConcreteElementA : Element
    {
        public override void Accept(Visitor visitor)
        {
            visitor.VisitConcreteElementA(this);
        }

        // 其他相關方法
        public void OperactionA()
        { }
    }
}
