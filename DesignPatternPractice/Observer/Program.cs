using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            //// 櫃台小姐童子婕
            //Secretary secretary = new Secretary();

            //// 看股票的同事
            //StockObserver colleague1 = new StockObserver("同事1", secretary);
            //NBAObserver colleague2 = new NBAObserver("同事2", secretary);

            //// 櫃台記下了兩位同事
            //secretary.Attach(colleague1);
            //secretary.Attach(colleague2);

            //// 發現老闆回來
            //secretary.SubjectState = "老闆回來囉!";

            //// 通知兩個同事
            //secretary.Notify();

            // 老闆胡漢三
            Boss boss = new Boss();

            // 看股票的同事
            StockObserver colleague1 = new StockObserver("同事1", boss);
            NBAObserver colleague2 = new NBAObserver("同事2", boss);

            boss.Attach(colleague1);
            boss.Attach(colleague2);
            boss.Detach(colleague1);

            // 老闆回來
            boss.SubjectState = "我胡漢三回來了!";

            // 發出通知
            boss.Notify();

            Console.ReadLine();
        }
    }
}
