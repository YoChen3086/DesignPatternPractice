using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class CashContext
    {
        private CashSuper cashSuper;

        public CashContext(string type)
        {
            switch (type)
            {
                case "正常收費":
                    this.cashSuper = new CashNormal();
                    break;
                case "打8折":
                    this.cashSuper = new CashRebate(0.8d);
                    break;
                case "滿300送100":
                    this.cashSuper = new CashReturn(300d, 100d);
                    break;
            }
        }

        public double GetResult(double money)
        {
            return cashSuper.acceptCash(money);
        }
    }
}
