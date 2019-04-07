using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public class Waiter
    {
        private Command command;

        // 設定訂單
        public void SetOrder(Command command)
        {
            this.command = command;
        }

        // 通知執行
        public void Notify()
        {
            command.ExecuteCommand();
        }
    }
}
