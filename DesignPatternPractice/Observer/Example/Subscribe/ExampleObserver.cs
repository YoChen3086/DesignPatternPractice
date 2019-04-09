using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public abstract class ExampleObserver
    {
        protected string name;
        protected Subject sub;

        public ExampleObserver(string name, Subject sub)
        {
            this.name = name;
            this.sub = sub;
        }

        public abstract void Update();
    }
}
