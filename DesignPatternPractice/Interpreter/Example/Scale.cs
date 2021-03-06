﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter
{
    public class Scale : Expression
    {
        public override void Execute(string key, double value)
        {
            string scale = "";
            switch (Convert.ToInt32(value))
            {
                case 1:
                    scale = "低音";
                    break;
                case 2:
                    scale = "中音";
                    break;
                case 3:
                    scale = "高音";
                    break;               
            }

            Console.Write($"{scale} ");
        }
    }
}
