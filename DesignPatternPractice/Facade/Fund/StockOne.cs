using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    public class StockOne
    {
        public void Sell()
        {
            Console.WriteLine("股票1賣出");
        }

        public void Buy()
        {
            Console.WriteLine("股票1買入");
        }
    }
}
