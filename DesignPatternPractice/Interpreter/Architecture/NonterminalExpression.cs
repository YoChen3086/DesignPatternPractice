using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter
{
    public class NonterminalExpression : AbstractExpression
    {
        public override void Interpret(Context context)
        {
            Console.WriteLine("非終端解譯器");
        }
    }
}
