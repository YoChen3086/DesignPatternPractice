using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public abstract class HandsetBrand
    {
        protected HandsetSoft soft;

        // 設定手機軟體
        public void SetHandsetSoft(HandsetSoft soft)
        {
            this.soft = soft;
        }

        // 執行
        public abstract void Run();
    }
}
