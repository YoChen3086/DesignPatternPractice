using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    public class Facade
    {
        // 外觀類別，他需要了解所有的子系統的方法或屬性，進行組合，以備外界調用
        SubSystemOne one;
        SubSystemTwo two;
        SubSystemThree three;
        SubSystemFour four;

        public Facade()
        {
            one = new SubSystemOne();
            two = new SubSystemTwo();
            three = new SubSystemThree();
            four = new SubSystemFour();
        }

        public void MethodA()
        {
            Console.WriteLine($"\n方法組A() ---");
            one.MethodOne();
            two.MethodTwo();
            four.MethodFour();
        }

        public void MethodB()
        {
            Console.WriteLine($"\n方法組B() ---");
            three.MethodThree();
            four.MethodFour();
        }
    }
}
