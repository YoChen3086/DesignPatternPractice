using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    public class RoleStateCaretaker
    {
        private RoleStateMemento memento;
        public RoleStateMemento Memento
        {
            get { return memento; }
            set { memento = value; }
        }
    }
}
