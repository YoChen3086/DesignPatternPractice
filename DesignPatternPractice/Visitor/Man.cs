using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public class Man : Person
    {
        public override void GetConclusion()
        {
            if (action == "成功")
            {
                Console.WriteLine($"{this.GetType().Name}{action}時，背後多半有一個偉大的女人。");
            }
            else if (action == "失敗")
            {
                Console.WriteLine($"{this.GetType().Name}{action}時，悶頭喝酒，誰也不用勸。");
            }
            else if (action == "戀愛")
            {
                Console.WriteLine($"{this.GetType().Name}{action}時，凡事不懂也要裝懂。");
            }
            else
            {
                // Nothing
            }
        }
    }
}
