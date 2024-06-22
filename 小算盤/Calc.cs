using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 小算盤
{
    internal class Calc
    {
        private double current;
        private double result;
        public String Current { 
            get 
            { 
                return current.ToString();
            }

            set 
            {
                double.TryParse(value, out current);
            }
        }
        public String Result {
            get
            {
                return result.ToString();
            }

            set
            {
                double.TryParse(value, out result);
            }
        }
        public String Operation { get; set; }

        public Calc() {
        }

        public String GetResult()
        {
            Operation operation = OperationFactory.Create(Operation, current, result);

            if (Operation == "/" && current == 0)
            {
                return "Error";
            }

            result = operation.getResult();

            return result.ToString();
        }
    }
}
