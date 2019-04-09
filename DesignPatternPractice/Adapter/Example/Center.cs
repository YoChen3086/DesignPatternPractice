using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class Center : Player
    {
        public Center(string name) : base(name)
        { }

        public override void Attack()
        {
            Console.WriteLine($"中鋒 {name} 進攻");
        }

        public override void Defense()
        {
            Console.WriteLine($"中鋒 {name} 防守");
        }
    }
}
