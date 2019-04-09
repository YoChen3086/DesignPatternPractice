using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Player playerA = new Forwards("Jordan");
            playerA.Attack();
            Player playerB = new Guards("Iverson");
            playerB.Attack();

            Player ym = new Translator("姚明");
            ym.Attack();
            ym.Defense();

            Console.WriteLine("\n");

            Target target = new Adapter();
            target.Request();

            Console.ReadLine();
        }
    }
}
