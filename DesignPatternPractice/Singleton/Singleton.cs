using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public sealed class Singleton
    {
        private static readonly Singleton instance = new Singleton();

        private static readonly object syncRoot = new object();

        private Singleton()
        { }

        public static Singleton GetInstance()
        {
            return instance;
        }
    }
}
