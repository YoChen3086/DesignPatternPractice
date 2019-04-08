using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public class Man : Person
    {
        public override void Accept(Action vistor)
        {
            // 首先在客戶程式中將具體狀態作為參數傳遞給[男人]類別完成了一次分派，
            // 然後[男人]類別呼叫作為參數的[具體狀態]中的方法[男人反應]，
            // 同時將自己(this)作為參數傳遞進去。這便完成了第二次分派
            vistor.GetManConclusion(this);
        }
    }
}
