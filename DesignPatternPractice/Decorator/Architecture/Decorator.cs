using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
   public abstract class Decorator : Component
    {
        protected Component component;

        public void SetComponent(Component component)
        {
            this.component = component;
        }

        // 重寫Operation()，實際執行的是Component的Operation()
        public override void Operation()
        {
            if (component != null)
            {
                component.Operation();
            }
        }
    }
}
