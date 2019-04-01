using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class Product
    {
        private IList<string> parts = new List<string>();

        public void Add(string part)
        {
            parts.Add(part);
        }

        public void Show()
        {
            Console.WriteLine("\n產品 建立 ----");
            foreach (string part in parts)
            {
                Console.WriteLine(part);
            }
        }
    }
}
