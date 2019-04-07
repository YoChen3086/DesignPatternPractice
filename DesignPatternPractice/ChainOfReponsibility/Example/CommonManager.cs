using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfReponsibility
{
    // 經理
    public class CommonManager : Manager
    {
        public CommonManager(string name) : base(name)
        { }

        public override void RequestApplications(Request request)
        {
            if (request.RequestType == "請假" && request.Number <= 2)
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
