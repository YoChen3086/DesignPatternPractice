using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class VolunteerFactory : IFactory
    {
        public Nightingale CreateNightingale()
        {
            return new Volunteer();
        }
    }
}
