using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    public class TestPaperA
    {
        public void TestQuestion1()
        {
            Console.WriteLine("題目1...");
            Console.WriteLine("答案: A");
        }

        public void TestQuestion2()
        {
            Console.WriteLine("題目2...");
            Console.WriteLine("答案: B");
        }

        public void TestQuestion3()
        {
            Console.WriteLine("題目3...");
            Console.WriteLine("答案: C");
        }
    }
}
