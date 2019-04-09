using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public class Leaf : Component
    {
        public Leaf(string name) : base(name)
        { }

        // 由於葉子沒有再增加分支和樹葉，所以Add和Remove方法實現他沒有意義，
        // 但這樣做可以消除葉節點和枝節點物件再抽象層次的區別，
        // 他們具備完全一致的介面
        public override void Add(Component component)
        {
            Console.WriteLine("Cannot add to a leaf");
        }

        public override void Remove(Component component)
        {
            Console.WriteLine("Cannot remove from a leaf");
        }

        // 葉節點的具體方法，此處是顯示其名稱和級別
        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name);
        }
    }
}
