using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public class ConcreteStateA : State
    {
        public override void Handle(Context context)
        {
            // 設定ConcreateStateA的下一狀態是B     
            context.State = new ConcreteStateB();
        }
    }
}
