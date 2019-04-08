using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public abstract class Person
    {
        // 接受
        public abstract void Accept(Action vistor);
    }
}
