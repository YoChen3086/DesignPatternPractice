using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class Target
    {
        public virtual void Request()
        {
            Console.WriteLine("普通請求!");
        }
    }
}
