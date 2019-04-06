using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            HandsetBrand phone = new HandsetBrandN();

            phone.SetHandsetSoft(new HandsetGame());
            phone.Run();

            phone.SetHandsetSoft(new HandsetAddressList());
            phone.Run();

            phone = new HandsetBrandM();

            phone.SetHandsetSoft(new HandsetGame());
            phone.Run();

            phone.SetHandsetSoft(new HandsetAddressList());
            phone.Run();

            Console.ReadLine();
        }
    }
}
