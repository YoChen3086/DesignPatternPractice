using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Resume resumeA = new Resume("大鳥");
            resumeA.SetPersonlInfo("男", 29);
            resumeA.SetWorkExperience("1998-2000", "XX公司");

            Resume resumeB = (Resume)resumeA.Clone();
            resumeB.SetWorkExperience("1998-2006", "YY企業");

            Resume resumeC = (Resume)resumeA.Clone();
            resumeC.SetPersonlInfo("男", 24);
            resumeC.SetWorkExperience("1998-2003", "ZZ企業");

            resumeA.Display();
            resumeB.Display();
            resumeC.Display();

            Console.WriteLine("\n");

            ConcretePrototype1 prototype1 = new ConcretePrototype1("My name is YoChen");
            ConcretePrototype1 prototype2 = (ConcretePrototype1)prototype1.Clone();
            Console.WriteLine($"Clone: {prototype2.Id}");

            Console.ReadLine();
        }
    }
}
