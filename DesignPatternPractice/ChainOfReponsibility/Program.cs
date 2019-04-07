using System;

namespace ChainOfReponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            //Handler h1 = new ConcreteHandler1();
            //Handler h2 = new ConcreteHandler2();
            //Handler h3 = new ConcreteHandler3();

            //h1.SetSuccessor(h2);
            //h2.SetSuccessor(h3);

            //int[] requests = { 2, 5, 14, 22, 18, 3, 27, 20 };

            //foreach (int request in requests)
            //{
            //    h1.HandleRequest(request);
            //}

            CommonManager commonManager = new CommonManager("經理");
            Majordomo majordomo = new Majordomo("總監");
            GeneralManager generalManager = new GeneralManager("總經理");
            commonManager.SetSuperior(majordomo);
            majordomo.SetSuperior(generalManager);

            Request request = new Request("請假", "小菜請假", 1);
            commonManager.RequestApplications(request);

            Request request2 = new Request("請假", "小菜請假", 4);
            commonManager.RequestApplications(request2);

            Request request3 = new Request("加薪", "小菜請求加薪", 500);
            commonManager.RequestApplications(request3);

            Request request4 = new Request("加薪", "小菜請求加薪", 1000);
            commonManager.RequestApplications(request4);

            Console.ReadLine();
        }
    }
}
