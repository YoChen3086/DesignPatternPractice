﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public class ConcreteImplementorB : Implementor
    {
        public override void Operation()
        {
            Console.WriteLine("具體實現B的方法執行");
        }
    }
}
