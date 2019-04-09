using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public class ConcreteStateB : State
    {
        public override void Handle(Context context)
        {
            // 設定ConcreateStateB的下一狀態是A
            context.State = new ConcreteStateA();
        }
    }
}
