using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter
{
    public class PlayContext
    {
        private string text;
        public string PlayText
        {
            get { return text; }
            set { text = value; }
        }
    }
}
