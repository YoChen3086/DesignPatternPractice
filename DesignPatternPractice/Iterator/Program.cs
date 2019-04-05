using System;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            // 公車，即聚集物件
            ConcreteAggregate aggregate = new ConcreteAggregate();

            aggregate[0] = "大鳥";
            aggregate[1] = "小菜";
            aggregate[2] = "行李";
            aggregate[3] = "老外";
            aggregate[4] = "巴士內部員工";
            aggregate[5] = "小偷";

            Iterator iterator = new ConcreteIterator(aggregate);
            while (!iterator.IsDone())
            {
                Console.WriteLine($"{iterator.CurrentItem()} 請買車票");
                iterator.Next();
            }

            Console.WriteLine();

            Iterator iterator2 = new ConcreteIteratorDesc(aggregate);
            while (!iterator2.IsDone())
            {
                Console.WriteLine($"{iterator2.CurrentItem()} 請買車票");
                iterator2.Next();
            }

            Console.ReadLine();
        }
    }
}
