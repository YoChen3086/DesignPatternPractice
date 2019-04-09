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

            ExampleProxy daili = new ExampleProxy(jiaojiao);

            daili.GiveDolls();
            daili.GiveFlowers();
            daili.GiveFlowers();

            Console.WriteLine("\n");

            Proxy proxy = new Proxy();
            proxy.Request();

            Console.ReadLine();
        }
    }
}
