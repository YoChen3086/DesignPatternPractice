using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    public class RealSubject : Subject
    {
        public override void Request()
        {
            Console.WriteLine("真實的請求");
        }
    }
}
