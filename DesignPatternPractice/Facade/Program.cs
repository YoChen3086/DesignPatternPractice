using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            StockOne stock1 = new StockOne();
            StockTwo stock2 = new StockTwo();
            NationDebtOne debt = new NationDebtOne();
            RealtyOne realty = new RealtyOne();

            stock1.Buy();
            stock2.Buy();
            debt.Buy();
            realty.Buy();

            stock1.Sell();
            stock2.Sell();
            debt.Sell();
            realty.Sell();

            Console.ReadLine();
        }
    }
}
