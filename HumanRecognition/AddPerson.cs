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
    public partial class AddPerson : Form
    {
        public AddPerson()
        {
            InitializeComponent();
        }
        bool can_request = false;
        string[] files_name;
        OpenFileDialog openFileDialog = new OpenFileDialog();
        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter =
                "Images (*.JPG;*.PNG;*.jpg;*.png)|*.JPG;*.PNG;*.jpg;*.png|" +
                "All files (*.*)|*.*";
            openFileDialog.Multiselect = true;
            openFileDialog.Title = "select images";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                can_request = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (can_request)
            {
                var client = new RestClient(Global.ipAdress + "/add_person");
                client.Timeout = -1;
                var request = new RestRequest(Method.POST);
                foreach (String file in openFileDialog.FileNames)
                {
                    request.AddFile("file", file);
                }
                request.AddParameter("name", txbName.Text);
                IRestResponse response = client.Execute(request);
                MessageBox.Show(response.Content);
            }
            
        }
    }
}
