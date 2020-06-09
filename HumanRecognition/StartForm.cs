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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetIP setIP = new SetIP();
            setIP.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IpToRun ipToRun = new IpToRun();
            ipToRun.ShowDialog();
        }
    }
}
