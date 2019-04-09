using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Work project = new Work();

            project.Hour = 9;
            project.WriteProgram();

            project.Hour = 10;
            project.WriteProgram();

            project.Hour = 12;
            project.WriteProgram();

            project.Hour = 13;
            project.WriteProgram();

            project.Hour = 14;
            project.WriteProgram();

            project.Hour = 17;

            project.TaskFinished = true;
            //WorkFinished = false;

            project.WriteProgram();

            project.Hour = 19;
            project.WriteProgram();

            project.Hour = 22;
            project.WriteProgram();

            Console.WriteLine("\n");

            Context context = new Context(new ConcreteStateA());
            // 不斷的請求，同時更改狀態
            context.Request();
            context.Request();
            context.Request();
            context.Request();

            Console.ReadLine();
        }
    }
}
