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
    public partial class AddActionItem : Form
    {
        public AddActionItem(bool add)
        {
            InitializeComponent();
            if (!add)
            {
                taskIdBox.ReadOnly = true;
            }
            statusComboBox.SelectedIndex = 0;
        }

        private void ConfigureStatusButton_Click(object sender, EventArgs e)
        {
            ArrayList allowedStatii = new ArrayList(statusComboBox.Items);
            StatusConfigure configForm = new StatusConfigure(allowedStatii);
            string selected = (string)statusComboBox.SelectedItem;
            configForm.ShowDialog();
            if (!configForm.SaveClose) return;
            statusComboBox.Items.Clear();
            foreach (object o in allowedStatii)
            {
                statusComboBox.Items.Add(o);
            }
            if (!statusComboBox.Items.Contains(selected))
            {
                statusComboBox.SelectedIndex = 0;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
