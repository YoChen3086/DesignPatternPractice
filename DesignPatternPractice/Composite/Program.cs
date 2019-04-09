using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteCompany companyRoot = new ConcreteCompany("北京總公司");
            companyRoot.Add(new HRDepartment("總公司人力資源部"));
            companyRoot.Add(new FinanceDepartment("總公司財務部"));

            ConcreteCompany companyA = new ConcreteCompany("上海華東分公司");
            companyA.Add(new HRDepartment("華東分公司人力資源部"));
            companyA.Add(new FinanceDepartment("華東分公司財務部"));
            companyRoot.Add(companyA);

            ConcreteCompany companyB = new ConcreteCompany("南京辦事處");
            companyB.Add(new HRDepartment("南京辦事處人力資源部"));
            companyB.Add(new FinanceDepartment("南京辦事處財務部"));
            companyA.Add(companyB);

            ConcreteCompany companyC = new ConcreteCompany("杭州辦事處");
            companyC.Add(new HRDepartment("杭州辦事處人力資源部"));
            companyC.Add(new FinanceDepartment("杭州辦事處財務部"));
            companyA.Add(companyC);

            Console.WriteLine("組織結構圖");
            companyRoot.Display(1);

            Console.WriteLine("\n職責");
            companyRoot.LineOfDuty();

            Console.WriteLine("\n");

            Composite root = new Composite("root");
            root.Add(new Leaf("Leaf A"));
            root.Add(new Leaf("Leaf B"));

            Composite comp = new Composite("Composite X");
            comp.Add(new Leaf("Leaf XA"));
            comp.Add(new Leaf("Leaf XB"));

            root.Add(comp);

            Composite comp2 = new Composite("Composite XY");
            comp2.Add(new Leaf("Leaf XYA"));
            comp2.Add(new Leaf("Leaf XYB"));

            comp.Add(comp2);

            root.Add(new Leaf("Leaf C"));

            Leaf leafD = new Leaf("Leaf D");
            root.Add(leafD);
            root.Remove(leafD);

            root.Display(1);            

            Console.ReadLine();
        }
    }
}
