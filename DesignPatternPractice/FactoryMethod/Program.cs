using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            IFactory factory = new UndergraduateFactory();
            Nightingale personA = factory.CreateNightingale();
            Nightingale personB = factory.CreateNightingale();
            Nightingale personC = factory.CreateNightingale();

            personA.Sweep();
            personB.Wash();
            personC.BuyRice();

            Console.ReadLine();
        }
    }
}
