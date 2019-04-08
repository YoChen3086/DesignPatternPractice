using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    public abstract class Country
    {
        protected UnitedNations mediator;

        public Country(UnitedNations mediator)
        {
            this.mediator = mediator;
        }
    }
}
