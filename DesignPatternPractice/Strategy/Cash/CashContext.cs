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
                    this.cashSuper = new CashRebate("0.8");
                    break;
                case "滿300送100":
                    this.cashSuper = new CashReturn("300", "100");
                    break;
            }
        }

        public double GetResult(double money)
        {
            return cashSuper.acceptCash(money);
        }
    }
}
