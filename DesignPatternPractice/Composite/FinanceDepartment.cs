using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public class FinanceDepartment : Company
    {
        public FinanceDepartment(string name) : base(name)
        { }

        public override void Add(Company company)
        {
            // Nothing
        }

        public override void Remove(Company company)
        {
            // Nothing
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name);
        }

        public override void LineOfDuty()
        {
            Console.WriteLine($"{name} 公司財務收支管理");
        }
    }
}
