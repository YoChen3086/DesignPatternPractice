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

            Resume resumeB = new Resume("大鳥");
            resumeB.SetPersonlInfo("男", 29);
            resumeB.SetWorkExperience("1998-2000", "XX公司");

            Resume resumeC = new Resume("大鳥");
            resumeC.SetPersonlInfo("男", 29);
            resumeC.SetWorkExperience("1998-2000", "XX公司");

            resumeA.Display();
            resumeB.Display();
            resumeC.Display();

            Console.ReadLine();
        }
    }
}
