using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    class StockTwo
    {
        public void Sell()
        {
            Console.WriteLine("股票2賣出");
        }

        public void Buy()
        {
            Console.WriteLine("股票2買入");
        }
    }
}
