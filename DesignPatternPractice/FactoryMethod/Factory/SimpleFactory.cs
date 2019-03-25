using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    [Obsolete]
    public class SimpleFactory
    {
        public static Nightingale CreateNightingale(string type)
        {
            Nightingale result = null;
            switch (type)
            {
                case "大學生":
                    result = new Undergraduate();
                    break;
                case "社區義工":
                    result = new Volunteer();
                    break;
            }

            return result;
        }
    }
}
