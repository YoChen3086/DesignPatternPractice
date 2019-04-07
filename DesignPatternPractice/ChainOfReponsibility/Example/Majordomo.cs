using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfReponsibility
{
    // 總監
    public class Majordomo : Manager
    {
        public Majordomo(string name) : base(name)
        { }

        public override void RequestApplications(Request request)
        {
            if (request.RequestType == "請假" && request.Number <= 5)
            {
                Console.WriteLine($"{name}: {request.RequestContent} 數量{request.Number} 被批准");
            }
            else
            {
                if (superior != null)
                {
                    superior.RequestApplications(request);
                }
            }
        }
    }
}
