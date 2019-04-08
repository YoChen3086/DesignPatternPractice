using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public abstract class Person
    {
        protected string action;
        public string Action
        {
            get { return action; }
            set { action = value; }
        }

        // 得到結論或反應
        public abstract void GetConclusion();
    }
}
