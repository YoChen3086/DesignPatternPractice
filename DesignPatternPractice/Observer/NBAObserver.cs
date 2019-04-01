using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public class NBAObserver : Observer
    {
        public NBAObserver(string name, Secretary sub) : base(name, sub)
        {
        }

        public override void Update()
        {
            Console.WriteLine($"{sub.SecretartAction} {name} 關閉NBA直播，繼續工作!");
        }
    }
}
