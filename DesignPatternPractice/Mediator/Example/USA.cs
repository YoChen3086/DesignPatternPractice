using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    public class USA : Country
    {
        public USA(UnitedNations mediator) : base(mediator)
        {
        }

        public void Delcare(string message)
        {
            mediator.Declare(message, this);
        }

        public void GetMessage(string message)
        {
            Console.WriteLine($"美國獲得對方資訊: {message}");
        }
    }
}
