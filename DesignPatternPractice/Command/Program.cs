using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            // 開店前的準備
            Barbecuer barbecuer = new Barbecuer();
            ExampleCommand bakeMuttonCommand1 = new BakeMuttonCommand(barbecuer);
            ExampleCommand bakeMuttonCommand2 = new BakeMuttonCommand(barbecuer);
            ExampleCommand bakeChickenWingCommand1 = new BakeChickenWingCommand(barbecuer);
            Waiter waiter = new Waiter();

            // 開門營業
            waiter.SetOrder(bakeMuttonCommand1);
            waiter.SetOrder(bakeMuttonCommand2);
            waiter.SetOrder(bakeChickenWingCommand1);

            // 點菜完畢，通知廚房
            waiter.Notify();

            Console.WriteLine("\n");

            Receiver receiver = new Receiver();
            Command command = new ConcreteCommand(receiver);
            Invoker invoker = new Invoker();

            invoker.SetCommand(command);
            invoker.ExecuteCommand();

            Console.ReadLine();
        }
    }
}
