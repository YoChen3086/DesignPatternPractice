using System;
using System.Collections.Generic;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            ObjectStructure structure = new ObjectStructure();
            structure.Attach(new Man());
            structure.Attach(new Woman());

            // 成功時的反應
            Action success = new Success();
            structure.Display(success);

            // 失敗時的反應
            Action failing = new Failing();
            structure.Display(failing);

            // 戀愛時的反應
            Action amativeness = new Amativeness();
            structure.Display(amativeness);

            // 結婚時的反應
            Action marriage = new Marriage();
            structure.Display(marriage);

            Console.ReadLine();
        }
    }
}
