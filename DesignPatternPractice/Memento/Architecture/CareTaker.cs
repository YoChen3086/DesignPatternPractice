using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    public class CareTaker
    {
        private Memento memento;

        public Memento Memento
        {
            get { return memento; }
            set { memento = value; }
        }
    }
}
