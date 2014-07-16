using Client.WCFServiceReference;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form_Client : Form
    {
        private DuplexServiceClient client;

        public Form_Client()
        {
            InitializeComponent();
        }

        private void Button_Login_Click(object sender, EventArgs e)
        {
            this.client = new DuplexServiceClient();
        }
    }
}
