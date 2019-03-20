using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class Finery : Person
    {
        protected Person component;

        // 打扮
        public void Decorate(Person component)
        {
            this.component = component;
        }

        public override void Show()
        {
            if (component != null)
            {
                component.Show();
            }            
        }
    }
}
