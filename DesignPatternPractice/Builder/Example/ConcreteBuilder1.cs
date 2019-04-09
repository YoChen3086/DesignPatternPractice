using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class ConcreteBuilder1 : Builder
    {
        private Product product = new Product();

        public override void BuildPartA()
        {
            product.Add("零件A");
        }

        public override void BuildPartB()
        {
            product.Add("零件B");
        }

        public override Product GetResult()
        {
            return product;
        }
    }
}
