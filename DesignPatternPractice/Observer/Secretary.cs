using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public class Secretary
    {
        // 同事列表
        private IList<StockObserver> observers = new List<StockObserver>();
        private string action;

        // 櫃台狀態
        public string SecretartAction
        {
            get { return action; }
            set { action = value; }
        }

        // 增加
        public void Attach(StockObserver observer)
        {
            observers.Add(observer);
        }

        // 通知
        public void Notify()
        {
            foreach (StockObserver observer in observers)
            {
                observer.Update();
            }
        }
    }
}
