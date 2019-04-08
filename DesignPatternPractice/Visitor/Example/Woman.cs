using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public class Woman : Person
    {
        public override void Accept(Action vistor)
        {
            vistor.GetWomanConclusion(this);
        }
    }
}
