using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    public class TestPaperA : TestPaper
    {
        protected override string Answer1()
        {
            return "A";
        }

        protected override string Answer2()
        {
            return "B";
        }

        protected override string Answer3()
        {
            return "C";
        }
    }
}
