using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public class StockObserver
    {
        private string name;
        private Subject sub;

        public StockObserver(string name, Subject sub)
        {
            this.name = name;
            this.sub = sub;
        }

        public void CloseStockMarket()
        {
            Console.WriteLine($"{sub.SubjectState} {name} 關閉股票行情，繼續工作!");
        }
    }
}
