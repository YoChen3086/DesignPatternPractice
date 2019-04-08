using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public abstract class Action
    {
        // 得到男人結論或反應
        public abstract void GetManConclusion(Man concreteElementA);
        // 得到女人結論或反應
        public abstract void GetWomanConclusion(Woman concreteElementB);
    }
}
