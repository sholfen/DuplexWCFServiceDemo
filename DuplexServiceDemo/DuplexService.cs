using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;

namespace DuplexServiceDemo
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class DuplexService : IDuplexService
    {
        private IDuplexServiceCallback callback = null;

        string IDuplexService.Login(string user, string password)
        {
            this.callback = OperationContext.Current.GetCallbackChannel<IDuplexServiceCallback>();
            return Guid.NewGuid().ToString();
        }

        void IDuplexService.Logout(string user, string token)
        {
            
        }

        void IDuplexService.SendMessage(string message)
        {
            Console.WriteLine("Message: " + message);
        }
    }
}
