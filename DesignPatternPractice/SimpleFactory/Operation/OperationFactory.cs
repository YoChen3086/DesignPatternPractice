using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    public class OperationFactory
    {
        public static Operation createOperation(string operate)
        {
            Operation operation = null;
            switch (operate)
            {
                case "+":
                    operation = new OperationAdd();
                    break;
                case "-":
                    operation = new OperationMinus();
                    break;
                case "*":
                    operation = new OperationMulti();
                    break;
                case "/":
                    operation = new OperationDivision();
                    break;
                default:
                    throw new Exception("錯誤:請輸入加減乘除!!");
            }

            return operation;
        }
    }
}
