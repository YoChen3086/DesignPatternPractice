using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfReponsibility
{
    // 總經理
    public class GeneralManager : Manager
    {
        public GeneralManager(string name) : base(name)
        { }

        public override void RequestApplications(Request request)
        {
            if (request.RequestType == "請假")
            {
                Console.WriteLine($"{name}: {request.RequestContent} 數量{request.Number} 被批准");
            }
            else if (request.RequestType == "加薪" && request.Number <= 500)
            {
                Console.WriteLine($"{name}: {request.RequestContent} 數量{request.Number} 被批准");
            }
            else if (request.RequestType == "加薪" && request.Number > 500)
            {
                Console.WriteLine($"{name}: {request.RequestContent} 數量{request.Number} 再說吧");
            }
        }
    }
}
