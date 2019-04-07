using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfReponsibility
{
    public class Request
    {
        private string type;
        private string content;
        private int number;

        public Request(string type, string content, int number)
        {
            this.type = type;
            this.content = content;
            this.number = number;
        }

        public string RequestType
        {
            get { return type; }
            set { type = value; }
        }

        public string RequestContent
        {
            get { return content; }
            set { content = value; }
        }

        public int Number
        {
            get { return number; }
            set { number = value; }
        }
    }
}
