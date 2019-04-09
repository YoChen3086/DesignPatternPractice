using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class Adapter : Target
    {
        // 建立一個私有的Adaptee物件
        private Adaptee adaptee = new Adaptee();

        // 這樣就可以把表面上調用Request()方法變成實際調用SpecificRequest()
        public override void Request()
        {
            adaptee.SpecificRequest();
        }
    }
}
