using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace AbstractFactory
{
    public class DataAccess
    {
        private static readonly string AssemblyName = "AbstractFactory";
        private static readonly string db = "SqlServer";
        //private static readonly string db = "Access";

        public static IUser CreateUser()
        {
            string className = $"{AssemblyName}.{db}User";
            return (IUser)Assembly.Load(AssemblyName).CreateInstance(className);
        }

        public static IDepartment CreateDepartment()
        {
            string className = $"{AssemblyName}.{db}Department";
            return (IDepartment)Assembly.Load(AssemblyName).CreateInstance(className);
        }
    }
}
