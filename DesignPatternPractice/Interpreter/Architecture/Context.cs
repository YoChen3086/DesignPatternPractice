using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter
{
   public  class Context
    {
        private string input;
        private string output;

        public string Input
        {
            get { return input; }
            set { input = value; }
        }

        public string Output
        {
            get { return output; }
            set { output = value; }
        }
    }
}
