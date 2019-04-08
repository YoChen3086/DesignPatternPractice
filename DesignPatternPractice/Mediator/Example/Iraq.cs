using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    public class Iraq : Country
    {
        public Iraq(UnitedNations mediator) : base(mediator)
        {
        }

        public void Declare(string message)
        {
            mediator.Declare(message, this);
        }

        public void GetMessage(string message)
        {
            Console.WriteLine($"伊拉克獲得對方資訊: {message}");
        }
    }
}
