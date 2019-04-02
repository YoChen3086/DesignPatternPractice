using System.Reflection;

namespace AbstractFactory
{
    public class DataAccess
    {
        private static readonly string AssemblyName = "AbstractFactory";
        // dotnet core 設定檔讀取方式需要再查查
        private static readonly string db = "SqlServer";

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
