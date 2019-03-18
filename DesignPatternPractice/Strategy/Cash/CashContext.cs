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

        public CashContext(CashSuper cashSuper)
        {
            this.cashSuper = cashSuper;
        }

        public double GetResult(double money)
        {
            return cashSuper.acceptCash(money);
        }
    }
}
