using System;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("請輸入數字A:");
                string strNumberA = Console.ReadLine();
                Console.WriteLine("請輸入加減乘除:");
                string strOperate = Console.ReadLine();
                Console.WriteLine("請輸入數字B:");
                string strNumberB = Console.ReadLine();

                Operation operation = OperationFactory.createOperation(strOperate);
                double result = operation.GetResult(Convert.ToDouble(strNumberA), Convert.ToDouble(strNumberB));
                Console.WriteLine($"結果: {result}");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}
