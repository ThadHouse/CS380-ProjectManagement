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
    public partial class TaskCreationForm : Form
    {
        public TaskCreationForm()
        {
            InitializeComponent();
            this.Size = new Size(this.Size.Width, (int)(this.Size.Height * 1.35));
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label19_Click(object sender, EventArgs e)
        {

        }

        private void Button13_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
