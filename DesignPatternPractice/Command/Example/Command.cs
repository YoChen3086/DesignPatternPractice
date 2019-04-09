using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public abstract class ExampleCommand
    {
        protected Barbecuer receiver;

        public ExampleCommand(Barbecuer receiver)
        {
            this.receiver = receiver;
        }

        // 執行命令
        public abstract void ExecuteCommand();
    }
}
