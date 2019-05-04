using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS380ProjectManagment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void Button4_Click(object sender, EventArgs e)
        {
            NewIssue openForm = new NewIssue();
            openForm.Text = "Update Issue";
            
            openForm.Show();
        }

        private void CreateIssue_Click(object sender, EventArgs e)
        {
            NewIssue openForm = new NewIssue();
            openForm.Show();
        }
    }
}
