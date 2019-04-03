using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public class RestState : State
    {
        public override void WriteProgram(Work work)
        {
            Console.WriteLine($"當前時間: {work.Hour}點 下班回家了");
        }
    }
}
