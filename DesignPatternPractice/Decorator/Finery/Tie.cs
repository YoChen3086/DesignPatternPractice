using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class Tie : Finery
    {
        public override void Show()
        {
            Console.Write("領帶 ");
        }
    }
}
