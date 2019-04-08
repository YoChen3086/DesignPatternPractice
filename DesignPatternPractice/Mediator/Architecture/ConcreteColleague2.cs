﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    public class ConcreteColleague2 : Colleague
    {
        public ConcreteColleague2(Mediator mediator) : base(mediator)
        {
        }

        public void Send(string message)
        {
            mediator.Send(message, this);
        }

        public void Notify(string message)
        {
            Console.WriteLine($"同事2得到資訊: {message}");
        }
    }
}
