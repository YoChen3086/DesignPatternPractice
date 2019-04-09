using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public abstract class Observer
    {
        protected string name;
        protected Subject subject;

        public Observer(Subject subject, string name)
        {
            this.subject = subject;
            this.name = name;            
        }

        public abstract void Function();
    }
}
