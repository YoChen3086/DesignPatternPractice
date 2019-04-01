﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public class Secretary
    {
        // 同事列表
        private IList<Observer> observers = new List<Observer>();
        private string action;

        // 櫃台狀態
        public string SecretartAction
        {
            get { return action; }
            set { action = value; }
        }

        // 增加
        public void Attach(Observer observer)
        {
            observers.Add(observer);
        }

        // 減少
        public void Detach(Observer observer)
        {
            observers.Remove(observer);
        }

        // 通知
        public void Notify()
        {
            foreach (Observer observer in observers)
            {
                observer.Update();
            }
        }
    }
}
