using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class SqlServerDepartment : IDepartment
    {
        public void Insert(Department department)
        {
            Console.WriteLine("在Sql server 中給Department表增加一條紀錄");
        }

        public Department GetDepartment(int id)
        {
            Console.WriteLine("在Sql server 中根據Id得到Department表一條紀錄");
            return null;
        }
    }
}
