using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    public class OperationAdd : Operation
    {
        public override double GetResult(double numberA, double numberB)
        {
            return numberA + numberB;
        }
    }
}
