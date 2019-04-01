using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public class StockObserver
    {
        private string name;
        private Secretary sub;

        public StockObserver(string name, Secretary sub)
        {
            this.name = name;
            this.sub = sub;
        }

        public void Update()
        {
            Console.WriteLine($"{sub.SecretartAction} {name} 關閉股票行情，繼續工作!");
        }
    }
}
