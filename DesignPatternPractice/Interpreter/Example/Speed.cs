using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter
{
    public class Speed : Expression
    {
        public override void Execute(string key, double value)
        {
            string speed;
            if (value < 500)
            {
                speed = "快速";
            }
            else if (value >= 1000)
            {
                speed = "慢速";
            }
            else
            {
                speed = "中速";
            }

            Console.Write($"{speed} ");
        }
    }
}
