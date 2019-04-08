using System;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteMediator mediator = new ConcreteMediator();

            ConcreteColleague1 colleague1 = new ConcreteColleague1(mediator);
            ConcreteColleague2 colleague2 = new ConcreteColleague2(mediator);

            mediator.Colleague1 = colleague1;
            mediator.Colleague2 = colleague2;

            colleague1.Send("吃過飯了嗎?");
            colleague2.Send("沒有呢，你打算請客?");

            Console.WriteLine("");

            UnitedNationsSecurityCouncil UNSC = new UnitedNationsSecurityCouncil();

            USA usa = new USA(UNSC);
            Iraq iraq = new Iraq(UNSC);

            UNSC.Colleague1 = usa;
            UNSC.Colleague2 = iraq;

            usa.Delcare("不准研製核武器，否則要發動戰爭!");
            iraq.Declare("我們沒有核武器，也不怕侵略");

            Console.ReadLine();
        }
    }
}
