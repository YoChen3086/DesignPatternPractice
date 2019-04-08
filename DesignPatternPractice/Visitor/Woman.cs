using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public class Woman : Person
    {
        public override void GetConclusion()
        {
            if (action == "成功")
            {
                Console.WriteLine($"{this.GetType().Name}{action}時，背後大多有一個不成功的男人。");
            }
            else if (action == "失敗")
            {
                Console.WriteLine($"{this.GetType().Name}{action}時，眼淚汪汪，誰也勸不了。");
            }
            else if (action == "戀愛")
            {
                Console.WriteLine($"{this.GetType().Name}{action}時，遇事懂也裝作不懂。");
            }
            else
            {
                // Nothing
            }
        }
    }
}
