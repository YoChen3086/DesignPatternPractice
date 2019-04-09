using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    public class ExampleProxy : IGiveGift
    {
        private Pursuit gg;

        public ExampleProxy(SchoolGirl mm)
        {
            gg = new Pursuit(mm);
        }

        public void GiveDolls()
        {
            gg.GiveDolls();
        }

        public void GiveFlowers()
        {
            gg.GiveFlowers();
        }

        public void GiveChocolate()
        {
            gg.GiveChocolate();
        }
    }
}
