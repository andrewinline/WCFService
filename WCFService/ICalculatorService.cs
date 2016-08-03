using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFService
{
    [ServiceContract]
    public interface ICalculatorService
    {
        [OperationContract]
        int Sum(int num1, int num2);

        [OperationContract]
        int Difference(int num1, int num2);

        [OperationContract]
        int Product(int num1, int num2);

        [OperationContract]
        int Division(int num1, int num2);

    }
}
