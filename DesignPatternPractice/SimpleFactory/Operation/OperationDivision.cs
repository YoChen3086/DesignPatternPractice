using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    public class OperationDivision : Operation
    {
        public override double GetResult()
        {
            if (NumberB == 0)
            {
                throw new Exception("錯誤:除數不可為0!!");
            }
            return NumberA / NumberB;
        }
    }
}
