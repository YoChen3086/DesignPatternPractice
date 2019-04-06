using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton s1 = Singleton.GetInstance();
            Singleton s2 = Singleton.GetInstance();

            if (s1 == s2)
            {
                Console.WriteLine($"兩個物件為相同實體");
            }

            Console.ReadLine();
        }
    }
}
