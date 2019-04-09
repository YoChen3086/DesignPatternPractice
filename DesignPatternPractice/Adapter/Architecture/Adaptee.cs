using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("特殊請求!");
        }
    }
}
