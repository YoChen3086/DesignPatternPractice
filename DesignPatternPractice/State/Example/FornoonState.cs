using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public class FornoonState : TimeState
    {
        public override void WriteProgram(Work work)
        {
            if (work.Hour < 12)
            {
                Console.WriteLine($"當前時間: {work.Hour}點 上午工作，精神百倍");
            }
            else
            {
                work.SetState(new NoonState());
                work.WriteProgram();
            }
        }
    }
}
