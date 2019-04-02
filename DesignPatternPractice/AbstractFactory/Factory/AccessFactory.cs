using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class AccessFactory : IFactory
    {
        public IUser CreateUser()
        {
            return new AccessUser();
        }
    }
}
