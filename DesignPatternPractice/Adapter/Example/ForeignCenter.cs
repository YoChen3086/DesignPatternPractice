using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class ForeignCenter
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public void 進攻()
        {
            Console.WriteLine($"中鋒 {name} 進攻");
        }

        public void 防守()
        {
            Console.WriteLine($"中鋒 {name} 防守");
        }
    }
}
