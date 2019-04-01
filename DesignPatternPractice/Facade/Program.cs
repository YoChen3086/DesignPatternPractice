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

            Console.ReadLine();
        }
    }
}
