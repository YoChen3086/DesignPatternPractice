using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    public class Fund
    {
        private StockOne stockOne;
        private StockTwo stockTwo;
        private NationDebtOne nationDebt;
        private RealtyOne realty;

        public Fund()
        {
            stockOne = new StockOne();
            stockTwo = new StockTwo();
            nationDebt = new NationDebtOne();
            realty = new RealtyOne();
        }

        public void BuyFund()
        {
            stockOne.Buy();
            stockTwo.Buy();
            nationDebt.Buy();
            realty.Buy();
        }

        public void SellFund()
        {
            stockOne.Sell();
            stockTwo.Sell();
            nationDebt.Sell();
            realty.Sell();
        }
    }
}
