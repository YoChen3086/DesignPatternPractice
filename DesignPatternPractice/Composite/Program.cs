using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteCompany root = new ConcreteCompany("北京總公司");
            root.Add(new HRDepartment("總公司人力資源部"));
            root.Add(new FinanceDepartment("總公司財務部"));

            ConcreteCompany companyA = new ConcreteCompany("上海華東分公司");
            companyA.Add(new HRDepartment("華東分公司人力資源部"));
            companyA.Add(new FinanceDepartment("華東分公司財務部"));
            root.Add(companyA);

            ConcreteCompany companyB = new ConcreteCompany("南京辦事處");
            companyB.Add(new HRDepartment("南京辦事處人力資源部"));
            companyB.Add(new FinanceDepartment("南京辦事處財務部"));
            companyA.Add(companyB);

            ConcreteCompany companyC = new ConcreteCompany("杭州辦事處");
            companyC.Add(new HRDepartment("杭州辦事處人力資源部"));
            companyC.Add(new FinanceDepartment("杭州辦事處財務部"));
            companyA.Add(companyC);

            Console.WriteLine("組織結構圖");
            root.Display(1);

            Console.WriteLine("\n職責");
            root.LineOfDuty();

            Console.ReadLine();
        }
    }
}
