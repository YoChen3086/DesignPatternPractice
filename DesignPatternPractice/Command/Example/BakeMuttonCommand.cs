﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public class BakeMuttonCommand : ExampleCommand
    {
        public BakeMuttonCommand(Barbecuer receiver) : base(receiver)
        { }

        public override void ExecuteCommand()
        {
            receiver.BakeMutton();
        }
    }
}
