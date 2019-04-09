using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    public class ConcreteClassA : AbstractClass
    {
        protected override void PrimitiveOperation1()
        {
            Console.WriteLine($"具體類別A方法1實現");
        }

        protected override void PrimitiveOperation2()
        {
            Console.WriteLine($"具體類別A方法2實現");
        }
    }
}
