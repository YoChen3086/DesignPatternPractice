using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    public class GameRole
    {
        // 生命力
        private int vitality;
        // 攻擊力
        private int attack;
        // 防禦力
        private int defense;

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

        public void StateDisplay()
        {
            Console.WriteLine("角色當前狀態");
            Console.WriteLine($"體力:　{vitality}");
            Console.WriteLine($"攻擊力: {attack}");
            Console.WriteLine($"防禦力: {defense}");
            Console.WriteLine();
        }

        public void GetInitState()
        {
            this.vitality = 100;
            this.attack = 100;
            this.defense = 100;
        }

        public void Fight()
        {
            this.vitality = 0;
            this.attack = 0;
            this.defense = 0;
        }

        // 保存角色狀態
        public RoleStateMemento SaveState()
        {
            return new RoleStateMemento(vitality, attack, defense);
        }

        // 恢復角色狀態
        public void RecoveryState(RoleStateMemento memento)
        {
            this.vitality = memento.Vitality;
            this.attack = memento.Attack;
            this.defense = memento.Defense;
        }
    }
}
