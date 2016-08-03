using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFService
{
    public class CalculatorService : ICalculatorService
    {


        public int Sum(int num1, int num2)
        {
            return (num1 + num2);
        }

        public int Difference(int num1, int num2)
        {
            return (num1 - num2);
        }

        public int Product(int num1, int num2)
        {
            return (num1 * num2);
        }

        public int Division(int num1, int num2)
        {
            return (num1 / num2);
        }
    }
}
