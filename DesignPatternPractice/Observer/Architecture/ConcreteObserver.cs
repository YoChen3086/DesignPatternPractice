using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public class ConcreteObserver : Observer
    {
        public ConcreteObserver(Subject subject, string name) : base(subject, name)
        { }

        public override void Function()
        {
            Console.WriteLine($"觀察者{name}的新狀態是{subject.SubjectState}");
        }
    }
}
