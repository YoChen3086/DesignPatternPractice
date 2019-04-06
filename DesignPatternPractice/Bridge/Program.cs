using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            HandsetBrand phone;

            phone = new HandsetBrandMAddressList();
            phone.Run();

            phone = new HandsetBrandMGame();
            phone.Run();

            phone = new HandsetBrandNAddressList();
            phone.Run();

            phone = new HandsetBrandNGame();
            phone.Run();

            Console.ReadLine();
        }
    }
}
