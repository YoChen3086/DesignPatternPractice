using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    public class OperationAdd : Operation
    {
        public override double GetResult()
        {
            return NumberA + NumberB;
        }
    }
}
