using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public abstract class Command
    {
        protected Barbecuer receiver;

        public Command(Barbecuer receiver)
        {
            this.receiver = receiver;
        }

        // 執行命令
        public abstract void ExecuteCommand();
    }
}
