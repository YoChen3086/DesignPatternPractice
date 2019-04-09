using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public class BakeChickenWingCommand : ExampleCommand
    {
        public BakeChickenWingCommand(Barbecuer receiver) : base(receiver)
        { }

        public override void ExecuteCommand()
        {
            receiver.BakeChickenWing();
        }
    }
}
