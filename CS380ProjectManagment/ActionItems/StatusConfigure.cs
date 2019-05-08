using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS380ProjectManagment.ActionItems
{
    public partial class StatusConfigure : Form
    {
        private ArrayList allowedStatii;

        public bool SaveClose { get; private set; } = false;
        public StatusConfigure(ArrayList allowedStatii)
        {
            this.allowedStatii = allowedStatii;
            InitializeComponent();
            foreach (object o in allowedStatii)
            {
                statiiListBox.Items.Add(o);
            }
        }

        private void StatusConfigure_FormClosing(object sender, FormClosingEventArgs e)
        {
            allowedStatii.Clear();
            foreach (object o in statiiListBox.Items)
            {
                allowedStatii.Add(o);
            }
        }

        private void AddAllowedButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(toAddBox.Text))
            {
                statiiListBox.Items.Add(toAddBox.Text);
            }
        }

        private void RemoveSelectedButton_Click(object sender, EventArgs e)
        {
            if (statiiListBox.SelectedIndex >= 0)
            {
                statiiListBox.Items.RemoveAt(statiiListBox.SelectedIndex);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveClose = true;
            this.Close();
        }
    }
}
