using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public class HRDepartment : Company
    {
        public HRDepartment(string name) : base(name)
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
            Console.WriteLine($"{name} 員工招聘教育訓練管理");
        }
    }
}
