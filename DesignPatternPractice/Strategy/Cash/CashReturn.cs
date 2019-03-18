using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class CashReturn : CashSuper
    {
        private double moneyCondition = 0.0d;
        private double moneyReturn = 0.0d;

        public CashReturn(string moneyCondition, string moneyReturn)
        {
            this.moneyCondition = Convert.ToDouble(moneyCondition);
            this.moneyReturn = Convert.ToDouble(moneyReturn);
        }

        public override double acceptCash(double money)
        {
            if (money >= moneyCondition)
            {
                return (money - Math.Floor(money / moneyCondition) * moneyReturn);
            }
            else
            {
                return money;
            }
        }
    }
}
