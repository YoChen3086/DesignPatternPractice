using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter
{
   public class TerminalExpression : AbstractExpression
    {
        public override void Interpret(Context context)
        {
            Console.WriteLine("終端解譯器");
        }
    }
}
