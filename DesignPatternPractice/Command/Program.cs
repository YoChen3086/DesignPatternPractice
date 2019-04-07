using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Barbecuer barbecuer = new Barbecuer();

            barbecuer.BakeMutton();
            barbecuer.BakeMutton();
            barbecuer.BakeMutton();
            barbecuer.BakeChickenWing();
            barbecuer.BakeMutton();
            barbecuer.BakeMutton();
            barbecuer.BakeChickenWing();

            Console.ReadLine();
        }
    }
}
