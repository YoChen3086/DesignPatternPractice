using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class CashFactory
    {
        public static CashSuper createCashAccept(string type)
        {
            CashSuper cashSuper = null;
            switch (type)
            {
                case "正常收費":
                    cashSuper = new CashNormal();
                    break;
                case "打8折":
                    cashSuper = new CashRebate(0.8d);
                    break;
                case "滿300送100":
                    cashSuper = new CashReturn(300d, 100d);
                    break;
            }

            return cashSuper;
        }
    }
}
