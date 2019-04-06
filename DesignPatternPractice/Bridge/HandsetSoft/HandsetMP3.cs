using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public class HandsetMP3 : HandsetSoft
    {
        public override void Run()
        {
            Console.WriteLine("執行手機MP3播放");
        }
    }
}
