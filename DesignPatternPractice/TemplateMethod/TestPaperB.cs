using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    public class TestPaperB : TestPaper
    {
        protected override string Answer1()
        {
            return "C";
        }

        protected override string Answer2()
        {
            return "A";
        }

        protected override string Answer3()
        {
            return "B";
        }
    }
}
