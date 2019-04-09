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

            Console.WriteLine();

            Originator originator = new Originator();
            // 狀態初始屬性為On
            originator.State = "On";
            originator.Show();

            CareTaker careTaker = new CareTaker();
            // 保存狀態時，由於有了很好的封裝，可以隱藏Originator的實現細節
            careTaker.Memento = originator.CreateMemento();

            // 狀態屬性改為Off
            originator.State = "Off";
            originator.Show();

            // 恢復原初始狀態
            originator.SetMemento(careTaker.Memento);
            originator.Show();

            Console.ReadLine();
        }
    }
}
