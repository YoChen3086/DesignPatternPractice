using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    public class TestPaper
    {
        public void TestQuestion1()
        {
            Console.WriteLine("題目1...");
            Console.WriteLine($"答案: {Answer1()}");
        }

        public void TestQuestion2()
        {
            Console.WriteLine("題目2...");
            Console.WriteLine($"答案: {Answer2()}");
        }

        public void TestQuestion3()
        {
            Console.WriteLine("題目3...");
            Console.WriteLine($"答案: {Answer3()}");
        }

        protected virtual string Answer1()
        {
            return "";
        }

        protected virtual string Answer2()
        {
            return "";
        }

        protected virtual string Answer3()
        {
            return "";
        }
    }
}
