using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HumanRecognition
{
    public partial class SetIP : Form
    {
        public SetIP()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txbIP.Text != "")
            {
                var client = new RestClient(Global.ipAdress + "/set_ip");
                client.Timeout = -1;
                var request = new RestRequest(Method.POST);
                request.AlwaysMultipartFormData = true;
                request.AddParameter("ip", txbIP.Text);
                IRestResponse response = client.Execute(request);
                MessageBox.Show(response.Content);
            }
        }
    }
}
