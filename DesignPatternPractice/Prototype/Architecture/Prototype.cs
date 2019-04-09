using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    public abstract class Prototype
    {
        private string id;
        public Prototype(string id)
        {
            this.id = id;
        }

        public string Id
        {
            get { return id; }
        }

        // 抽象類別關鍵就是有這樣一個Clone方法
        public abstract Prototype Clone();
    }
}
