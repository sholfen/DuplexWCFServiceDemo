using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class Form_Main : Form
    {
        private ServiceHost mHost = null;

        public Form_Main()
        {
            InitializeComponent();
        }

        private void Button_StartService_Click(object sender, EventArgs e)
        {
            this.mHost = new ServiceHost(typeof(DuplexServiceDemo.DuplexService));
            this.mHost.Open();
            object instance = this.mHost.SingletonInstance;
            //Console.WriteLine(instance.GetType().FullName);
            Console.WriteLine("Service Started");
        }

        private void Button_StopService_Click(object sender, EventArgs e)
        {
            if (this.mHost != null)
            {
                this.mHost.Close();
                Console.WriteLine("Service Closed");
            }
        }

        private void Button_Send_Click(object sender, EventArgs e)
        {

        }
    }
}
