using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public class Work
    {
        // 狀態
        private State current;
        // 鐘點
        private int hour;
        // 任務完成標記
        private bool finish = false;

        public Work()
        {
            current = new FornoonState();
        }

        public int Hour
        {
            get { return hour; }
            set { hour = value; }
        }

        public bool TaskFinished
        {
            get { return finish; }
            set { finish = value; }
        }

        public void SetState(State state)
        {
            current = state;
        }

        public void WriteProgram()
        {
            current.WriteProgram(this);
        }
    }
}
