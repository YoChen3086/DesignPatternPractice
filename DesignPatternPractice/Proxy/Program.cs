using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            // jiaojiao 被追求者
            // daili 代理追求者
            // zhuojiayi 追求者

            SchoolGirl jiaojiao = new SchoolGirl();
            jiaojiao.Name = "嬌嬌";

            Pursuit zhuojiayi = new Pursuit(jiaojiao);

            zhuojiayi.GiveDolls();
            zhuojiayi.GiveFlowers();
            zhuojiayi.GiveFlowers();

            Console.ReadLine();
        }
    }
}
