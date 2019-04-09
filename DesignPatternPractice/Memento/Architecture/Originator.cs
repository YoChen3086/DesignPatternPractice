using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    public class Originator
    {
        // 需要保存的屬性，可能有多個
        private string state;
        public string State
        {
            get { return state; }
            set { state = value; }
        }

        // 建立備忘錄，將需要保存的資訊傳入並實體化出一個Memento物件
        public Memento CreateMemento()
        {
            return new Memento(state);
        }

        // 恢復備忘錄，將Memento導入並將相關資料恢復
        public void SetMemento(Memento memento)
        {
            state = memento.State;
        }

        // 顯示資料
        public void Show()
        {
            Console.WriteLine($"State= {state}");
        }
    }
}
