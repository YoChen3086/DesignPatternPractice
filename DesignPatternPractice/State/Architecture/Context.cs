using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public class Context
    {
        private State state;
        public Context(State state)
        {
            this.state = state;
        }

        public State State
        {
            get { return state; }
            set
            {
                state = value;
                Console.WriteLine($"當前狀態: {state.GetType().Name}");
            }
        }

        public void Request()
        {
            // 對請求做處理，並設定下一狀態
            state.Handle(this);
        }
    }
}
