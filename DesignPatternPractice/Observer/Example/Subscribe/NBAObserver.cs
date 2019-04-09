using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public class NBAObserver
    {
        private string name;
        private ExampleSubject sub;

        public NBAObserver(string name, ExampleSubject sub)
        {
            this.name = name;
            this.sub = sub;
        }

        public void CloseNBADirectSeeding()
        {
            Console.WriteLine($"{sub.SubjectState} {name} 關閉NBA直播，繼續工作!");
        }
    }
}
