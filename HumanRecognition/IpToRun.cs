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
    public partial class IpToRun : Form
    {
        public IpToRun()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txpIP.Text != "")
            {
                Global.ipAdress = "http://"+txpIP.Text+":8000";
                main main = new main();
                main.ShowDialog();
            }
        }
    }
}
