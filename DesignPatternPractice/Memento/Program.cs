using System;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            // 打王前
            GameRole character = new GameRole();

            character.GetInitState();
            character.StateDisplay();

            // 保存進度
            GameRole backup = new GameRole();
            backup.Vitality = character.Vitality;
            backup.Attack = character.Attack;
            backup.Defense = character.Defense;

            // 打王
            character.Fight();
            character.StateDisplay();

            // 讀取檔案
            character.Vitality = backup.Vitality;
            character.Attack = backup.Attack;
            character.Defense = backup.Defense;

            character.StateDisplay();

            Console.ReadLine();
        }
    }
}
