using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public class EveningState : State
    {
        public override void WriteProgram(Work work)
        {
            if (work.TaskFinished)
            {
                work.SetState(new RestState());
                work.WriteProgram();
            }
            else
            {
                if (work.Hour < 21)
                {
                    Console.WriteLine($"當前時間: {work.Hour}點 加班喔，疲勞至極");
                }
                else
                {
                    work.SetState(new SleepingState());
                    work.WriteProgram();
                }
            }
        }
    }
}
