using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    public abstract class AbstractClass
    {
        // 一些抽象行為放到子類別去實現
        protected abstract void PrimitiveOperation1();
        protected abstract void PrimitiveOperation2();

        public void TemplateMethod()
        {
            // 範本方法，給出了邏輯框架，
            // 而邏輯的組成是一些相應的抽象操作，他們都推遲到子類別去實現。
            PrimitiveOperation1();
            PrimitiveOperation2();
            Console.WriteLine();
        }
    }
}
