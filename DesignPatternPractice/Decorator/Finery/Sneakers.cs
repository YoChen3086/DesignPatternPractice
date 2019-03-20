using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class Sneakers : Finery
    {
        public override void Show()
        {
            Console.Write("破球鞋 ");
            base.Show();
        }
    }
}
