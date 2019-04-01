using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            // 櫃台小姐童子婕
            Secretary secretary = new Secretary();

            // 看股票的同事
            StockObserver colleague1 = new StockObserver("同事1", secretary);
            StockObserver colleague2 = new StockObserver("同事2", secretary);

            // 櫃台記下了兩位同事
            secretary.Attach(colleague1);
            secretary.Attach(colleague2);

            // 發現老闆回來
            secretary.SecretartAction = "老闆回來囉!";

            // 通知兩個同事
            secretary.Notify();

            Console.ReadLine();
        }
    }
}
