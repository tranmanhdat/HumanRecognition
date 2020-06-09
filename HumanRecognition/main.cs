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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void btnPredict_Click(object sender, EventArgs e)
        {
            frmPredict frmPredict = new frmPredict();
            frmPredict.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddPerson addPerson = new AddPerson();
            addPerson.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            frmDelete frmDelete = new frmDelete();
            frmDelete.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetAllId getAllId = new GetAllId();
            getAllId.ShowDialog();
        }
    }

    public static class Global
    {
        public static string ipAdress = "http://192.168.20.20:8000";
    }
}
