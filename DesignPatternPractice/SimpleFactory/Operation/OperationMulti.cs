using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    public class OperationMulti : Operation
    {
        public override double GetResult()
        {
            return NumberA * NumberB;
        }
    }
}
