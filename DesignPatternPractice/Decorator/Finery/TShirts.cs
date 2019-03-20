using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class TShirts : Finery
    {
        public override void Show()
        {
            Console.Write("大T恤 ");
        }
    }
}
