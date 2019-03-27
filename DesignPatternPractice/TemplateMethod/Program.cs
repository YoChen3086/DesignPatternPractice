using System;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("學生甲抄的試卷 :");
            TestPaperA paperA = new TestPaperA();
            paperA.TestQuestion1();
            paperA.TestQuestion2();
            paperA.TestQuestion3();

            Console.WriteLine();

            Console.WriteLine("學生乙抄的試卷 :");
            TestPaperB paperB = new TestPaperB();
            paperB.TestQuestion1();
            paperB.TestQuestion2();
            paperB.TestQuestion3();

            Console.ReadLine();
        }
    }
}
