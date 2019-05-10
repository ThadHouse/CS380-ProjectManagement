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
    public partial class AddResource : Form
    {
        private ResourceData resourceData;
        public AddResource(ResourceData resourceData)
        {
            this.resourceData = resourceData;
            InitializeComponent();
            this.AddSaveHandler(saveButton);
            this.AddCloseHandler(cancelButton);

            if (resourceData != null)
            {
                this.Text = "Update Resource";
                titleTextBox.Text = resourceData.Title;
                nameTextBox.Text = resourceData.Name;
                idTextBox.Text = resourceData.Id.ToString();
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                MessageBox.Show("Must enter a name");
                return;
            }
            if (resourceData == null)
            {
                resourceData = Database.NewItem<ResourceData>(nameTextBox.Text, "");
            }
            resourceData.Name = nameTextBox.Text;
            resourceData.Title = titleTextBox.Text;
            Database.Save();
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
