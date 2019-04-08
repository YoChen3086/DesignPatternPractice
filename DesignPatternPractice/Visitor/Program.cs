using System;
using System.Collections.Generic;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            SampleObjectStructure sampleObjectStructure = new SampleObjectStructure();
            sampleObjectStructure.Attach(new Man());
            sampleObjectStructure.Attach(new Woman());

            // 成功時的反應
            Action success = new Success();
            sampleObjectStructure.Display(success);

            // 失敗時的反應
            Action failing = new Failing();
            sampleObjectStructure.Display(failing);

            // 戀愛時的反應
            Action amativeness = new Amativeness();
            sampleObjectStructure.Display(amativeness);

            // 結婚時的反應
            Action marriage = new Marriage();
            sampleObjectStructure.Display(marriage);

            Console.WriteLine();

            ObjectStructure objectStructure = new ObjectStructure();
            objectStructure.Attach(new ConcreteElementA());
            objectStructure.Attach(new ConcreteElementB());

            Visitor concreteVisitor1 = new ConcreteVisitor1();
            Visitor concreteVisitor2 = new ConcreteVisitor2();

            objectStructure.Accept(concreteVisitor1);
            objectStructure.Accept(concreteVisitor2);

            Console.ReadLine();
        }
    }
}
