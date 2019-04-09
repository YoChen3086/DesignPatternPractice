using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public class AfternoonState : TimeState
    {
        public override void WriteProgram(Work work)
        {
            if (work.Hour < 17)
            {
                Console.WriteLine($"當前時間: {work.Hour}點 下午狀態還不錯，繼續努力");
            }
            else
            {
                work.SetState(new EveningState());
                work.WriteProgram();
            }
        }
    }
}
