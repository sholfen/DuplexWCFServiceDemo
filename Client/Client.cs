using Client.WCFServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public class DuplexServiceClient : IDuplexServiceCallback
    {
        public Action<string> mReceiveMessageAction = null;
        private InstanceContext mInstanceContext = null;
        private WCFServiceReference.DuplexServiceClient mClient = null;
        private string mToken = string.Empty;

        public DuplexServiceClient()
        {
            this.mInstanceContext = new InstanceContext(this);
            this.mClient = new WCFServiceReference.DuplexServiceClient(this.mInstanceContext);
            this.mToken = this.mClient.Login("aaa3", "aaa4");
            Console.WriteLine("Token:" + this.mToken);
        }

        void IDuplexServiceCallback.ReceiveMessage(string message)
        {
            if (mReceiveMessageAction != null)
            {
                this.mReceiveMessageAction(message);
            }
        }

        public void SendMessage(string message)
        {
            this.mClient.SendMessage(message);
        }
    }
}
