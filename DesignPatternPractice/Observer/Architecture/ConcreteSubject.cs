using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public class ConcreteSubject : Subject
    {
        // 宣告一事件Update，類型為委託EventHandler
        public event EventHandler Update;
        private string action;

        public string SubjectState
        {
            get { return action; }
            set
            {
                // 通知
                if (value != action)
                {
                    action = value;
                    Update();
                }
            }
        }

        //// 通知
        //public void Notify()
        //{
        //    Update();
        //}
    }
}
