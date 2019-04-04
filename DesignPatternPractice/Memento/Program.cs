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
            RoleStateCaretaker stateAdmin = new RoleStateCaretaker();
            stateAdmin.Memento = character.SaveState();

            // 打王
            character.Fight();
            character.StateDisplay();

            // 讀取檔案
            character.RecoveryState(stateAdmin.Memento);

            character.StateDisplay();

            Console.ReadLine();
        }
    }
}
