using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class Suit : Finery
    {
        public override void Show()
        {
            Console.Write("西裝 ");
        }
    }
}
