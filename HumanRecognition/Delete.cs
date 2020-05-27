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
    public partial class frmDelete : Form
    {
        public frmDelete()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = 0;
            if (int.TryParse(txtID.Text, out id))
            {
                var client = new RestClient(Global.ipAdress+"/del_person");
                client.Timeout = -1;
                var request = new RestRequest(Method.POST);
                request.AlwaysMultipartFormData = true;
                request.AddParameter("id_person", id.ToString());
                IRestResponse response = client.Execute(request);
                MessageBox.Show(response.Content);
            }
        }
    }
}
