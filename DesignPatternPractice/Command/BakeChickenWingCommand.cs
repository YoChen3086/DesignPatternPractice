using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public class BakeChickenWingCommand : Command
    {
        public BakeChickenWingCommand(Barbecuer receiver) : base(receiver)
        { }

        public override void ExecuteCommand()
        {
            receiver.BakeChickenWing();
        }
    }
}
