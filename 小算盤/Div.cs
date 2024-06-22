using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 小算盤
{
    internal class Div : Operation
    {
        public double Num1;
        public double Num2;
        public Div(double num1, double num2)
        {
            Num1 = num1;
            Num2 = num2;
        }

        public override double getResult()
        {
            return Num1 / Num2;
        }

      
    }
}
