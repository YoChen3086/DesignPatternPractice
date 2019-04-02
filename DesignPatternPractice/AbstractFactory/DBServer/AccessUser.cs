using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class AccessUser : IUser
    {
        public void Insert(User user)
        {
            Console.WriteLine("在Access 中給User表增加一條紀錄");
        }

        public User GetUser(int id)
        {
            Console.WriteLine("在Access 中根據Id得到User表一條紀錄");
            return null;
        }
    }
}
