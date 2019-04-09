using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public class NoonState : TimeState
    {
        public override void WriteProgram(Work work)
        {
            if (work.Hour < 13)
            {
                Console.WriteLine($"當前時間: {work.Hour}點 餓了午休吃飯睡覺");
            }
            else
            {
                work.SetState(new AfternoonState());
                work.WriteProgram();
            }
        }
    }
}
