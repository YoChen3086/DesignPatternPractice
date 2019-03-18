using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    public class OperationDivision : Operation
    {
        public override double GetResult(double numberA, double numberB)
        {
            if (numberB == 0)
            {
                throw new Exception("錯誤:除數不可為0!!");
            }
            return numberA / numberB;
        }
    }
}
