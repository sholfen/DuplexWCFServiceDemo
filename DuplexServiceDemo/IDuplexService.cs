using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;


namespace DuplexServiceDemo
{
    [ServiceContract(CallbackContract = typeof(IDuplexServiceCallback))]
    public interface IDuplexService
    {
        [OperationContract]
        string Login(string user, string password);

        [OperationContract(IsOneWay=true)]
        void Logout(string user, string token);

        [OperationContract(IsOneWay = true)]
        void SendMessage(string message);
    }

    public interface IDuplexServiceCallback
    {
        [OperationContract]
        void ReceiveMessage(string message);
    }
}
