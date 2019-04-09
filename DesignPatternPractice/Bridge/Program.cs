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

            Console.WriteLine("\n");

            Abstraction abstraction = new Abstraction();
            abstraction.SetImplementor(new ConcreteImplementorA());
            abstraction.Operation();

            abstraction.SetImplementor(new ConcreteImplementorB());
            abstraction.Operation();

            Console.ReadLine();
        }
    }
}
