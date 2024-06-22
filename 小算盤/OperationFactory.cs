using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 小算盤
{
    internal class OperationFactory
    {

        public OperationFactory() { }

        public static Operation Create(String operationString, double current, double result)
        {
            Operation operation = null;
            switch (operationString)
            {
                case "+":
                    operation = new Add(current, result);
                    break;
                case "-":
                    operation = new Sub(current, result);
                    break;
                case "*":
                    operation = new Multi(current, result);
                    break;
                case "/":
                    operation = new Div(current, result);
                    break;
                default:
                    break;
            }
            return operation;
        }
    }
}
