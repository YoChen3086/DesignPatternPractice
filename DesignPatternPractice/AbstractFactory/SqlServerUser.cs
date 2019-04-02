using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class SqlServerUser
    {
        public void Insert(User user)
        {
            Console.WriteLine("在Sql server 中給User表增加一條紀錄");
        }

        public void GetUser(int id)
        {
            Console.WriteLine("在Sql server 中根據Id得到User表一條紀錄");
        }
    }
}
