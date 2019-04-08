﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter
{
    public class Note : Expression
    {
        public override void Execute(string key, double value)
        {
            string note = "";
            switch (key)
            {
                case "C":
                    note = "1";
                    break;
                case "D":
                    note = "2";
                    break;
                case "E":
                    note = "3";
                    break;
                case "F":
                    note = "4";
                    break;
                case "G":
                    note = "5";
                    break;
                case "A":
                    note = "6";
                    break;
                case "B":
                    note = "7";
                    break;
            }

            Console.Write($"{note} ");
        }
    }
}
