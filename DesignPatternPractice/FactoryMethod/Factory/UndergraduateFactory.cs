using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class UndergraduateFactory : IFactory
    {
        public Nightingale CreateNightingale()
        {
            return new Undergraduate();
        }
    }
}
