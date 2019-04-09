using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public class Waiter
    {
        private IList<ExampleCommand> orders = new List<ExampleCommand>();

        // 設定訂單
        public void SetOrder(ExampleCommand command)
        {
            if (command.ToString() == "Command.BakeChickenWingCommand")
            {
                Console.WriteLine($"服務生:雞翅沒有了，請點別的");
            }
            else
            {
                orders.Add(command);
                Console.WriteLine($"增加訂單: {command.ToString()}, 時間: {DateTime.Now.ToString()}");
            }
        }

        // 取消訂單
        public void CancelOrder(ExampleCommand command)
        {
            orders.Remove(command);
            Console.WriteLine($"取消訂單: {command.ToString()}, 時間: {DateTime.Now.ToString()}");
        }

        // 通知全部執行
        public void Notify()
        {
            foreach (ExampleCommand command in orders)
            {
                command.ExecuteCommand();
            }
        }
    }
}
