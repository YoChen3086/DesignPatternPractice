using System;

namespace State
{
    class Program
    {
        // 鐘點
        static int Hour = 0;

        // 任務完成標記
        static bool WorkFinished = false;

        static void Main(string[] args)
        {
            Hour = 9;
            WriteProgram();

            Hour = 10;
            WriteProgram();

            Hour = 12;
            WriteProgram();

            Hour = 13;
            WriteProgram();

            Hour = 14;
            WriteProgram();

            Hour = 17;

            WorkFinished = true;
            //WorkFinished = false;

            WriteProgram();

            Hour = 19;
            WriteProgram();


            Hour = 22;
            WriteProgram();

            Console.ReadLine();
        }

        public static void WriteProgram()
        {
            if (Hour < 12)
            {
                Console.WriteLine($"當前時間: {Hour}點 上午工作，精神百倍");
            }
            else if (Hour < 13)
            {
                Console.WriteLine($"當前時間: {Hour}點 餓了午休吃飯睡覺");
            }
            else if (Hour < 17)
            {
                Console.WriteLine($"當前時間: {Hour}點 下午狀態還不錯");
            }
            else
            {
                if (WorkFinished)
                {
                    Console.WriteLine($"當前時間: {Hour}點 下班回家了");
                }
                else
                {
                    if (Hour < 21)
                    {
                        Console.WriteLine($"當前時間: {Hour}點 加班喔，疲累至極");
                    }
                    else
                    {
                        Console.WriteLine($"當前時間: {Hour}點 不行了，睡著了");
                    }
                }
            }
        }
    }
}
