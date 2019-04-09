using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    public class ConcretePrototype1 : Prototype
    {
        public ConcretePrototype1(string id) : base(id)
        { }

        public override Prototype Clone()
        {
            // 建立物件的淺表副本。方法是建立一個新物件，然後將物件的非靜態欄位複製到該新物件。
            // 如果欄位是值類型的，則對該欄位執行逐位複製。
            // 如果欄位是參考類型，則複製參考但不複製參考的物件；
            // 因此，原始物件及其副本參考同一物件。
            return (Prototype)this.MemberwiseClone();
        }
    }
}
