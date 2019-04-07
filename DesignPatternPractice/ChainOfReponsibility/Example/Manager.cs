using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfReponsibility
{
    public abstract class Manager
    {
        protected string name;
        protected Manager superior;

        public Manager(string name)
        {
            this.name = name;
        }

        // 設定管理者的上級
        public void SetSuperior(Manager superior)
        {
            this.superior = superior;
        }

        // 申請請求
        public abstract void RequestApplications(Request request);
    }
}
