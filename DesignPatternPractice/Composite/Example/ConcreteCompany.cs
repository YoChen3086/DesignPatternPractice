using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public class ConcreteCompany : Company
    {
        private IList<Company> children = new List<Company>();

        public ConcreteCompany(string name) : base(name)
        { }

        public override void Add(Company company)
        {
            children.Add(company);
        }

        public override void Remove(Company company)
        {
            children.Remove(company);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name);

            foreach (Company company in children)
            {
                company.Display(depth + 2);
            }
        }

        public override void LineOfDuty()
        {
            foreach (Company company in children)
            {
                company.LineOfDuty();
            }
        }
    }
}
