using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public class StockObserver : Observer
    {
        public StockObserver(string name, Secretary sub) : base(name, sub)
        {
        }

        public override void Update()
        {
            Console.WriteLine($"{sub.SecretartAction} {name} 關閉股票行情，繼續工作!");
        }
    }
}
