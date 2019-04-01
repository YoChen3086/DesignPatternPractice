using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public abstract class Observer
    {
        protected string name;
        protected Secretary sub;

        public Observer(string name, Secretary sub)
        {
            this.name = name;
            this.sub = sub;
        }

        public abstract void Update();
    }
}
