using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public class Work
    {
        // 鐘點
        private int hour;
        // 任務完成標記
        private bool finish = false;

        public int Hour
        {
            get { return hour; }
            set { hour = value; }
        }

        public bool TaskFinished
        {
            get { return finish; }
            set { finish = value; }
        }

        public void WriteProgram()
        {
            if (hour < 12)
            {
                Console.WriteLine($"當前時間: {hour}點 上午工作，精神百倍");
            }
            else if (hour < 13)
            {
                Console.WriteLine($"當前時間: {hour}點 餓了午休吃飯睡覺");
            }
            else if (hour < 17)
            {
                Console.WriteLine($"當前時間: {hour}點 下午狀態還不錯");
            }
            else
            {
                if (finish)
                {
                    Console.WriteLine($"當前時間: {hour}點 下班回家了");
                }
                else
                {
                    if (hour < 21)
                    {
                        Console.WriteLine($"當前時間: {hour}點 加班喔，疲累至極");
                    }
                    else
                    {
                        Console.WriteLine($"當前時間: {hour}點 不行了，睡著了");
                    }
                }
            }
        }
    }
}
