using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class AccessDepartment : IDepartment
    {
        public void Insert(Department department)
        {
            Console.WriteLine("在Access 中給Department表增加一條紀錄");
        }

        public Department GetDepartment(int id)
        {
            Console.WriteLine("在Access 中根據Id得到Department表一條紀錄");
            return null;
        }
    }
}
