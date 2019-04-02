using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class User
    {
        private int _id;
        private string _name;

        public User(int id, string name)
        {
            this._id = id;
            this._name = name;
        }

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }
}
