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
    public partial class NewIssue : Form
    {
        public NewIssue()
        {
            InitializeComponent();
            this.Size = new Size(this.Size.Width, (int)(this.Size.Height * 1.15));
        }

        private void MonthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}
