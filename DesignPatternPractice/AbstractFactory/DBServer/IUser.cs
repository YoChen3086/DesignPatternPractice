using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public interface IUser
    {
        void Insert(User user);

        User GetUser(int id);
    }
}
