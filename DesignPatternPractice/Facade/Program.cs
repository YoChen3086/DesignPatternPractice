using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Fund fund = new Fund();

            // 基金買入
            fund.BuyFund();

            // 基金贖回
            fund.SellFund();

            // 由於Facade的作用，用戶端可以根本不知三個子系統類別的存在
            Facade facade = new Facade();
            facade.MethodA();
            facade.MethodB();

            Console.ReadLine();
        }
    }
}
