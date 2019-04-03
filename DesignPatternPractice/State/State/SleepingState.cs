using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public class SleepingState : State
    {
        public override void WriteProgram(Work work)
        {
            Console.WriteLine($"當前時間: {work.Hour}點 不行了，睡著了");
        }
    }
}
