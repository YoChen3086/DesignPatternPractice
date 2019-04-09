using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    public class RoleStateMemento
    {
        // 生命力
        private int vitality;
        // 攻擊力
        private int attack;
        // 防禦力
        private int defense;

        public RoleStateMemento(int vit, int atk, int def)
        {
            this.vitality = vit;
            this.attack = atk;
            this.defense = def;
        }

        public int Vitality
        {
            get { return vitality; }
            set { vitality = value; }
        }

        public int Attack
        {
            get { return attack; }
            set { attack = value; }
        }

        public int Defense
        {
            get { return defense; }
            set { defense = value; }
        }

    }
}
