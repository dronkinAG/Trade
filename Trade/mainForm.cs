using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TradeApplication
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var f = new authForm();
            f.ShowDialog();
        }

        private void vvvffToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void firmsMenuItem_Click(object sender, EventArgs e)
        {
            var f = new firmsForm();
            
            f.Show();
        }
    }
}
