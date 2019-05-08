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
        private ActionItemData itemData;
        private ResourceData selectedResource;
        public AddActionItem(ActionItemData itemData)
        {
            InitializeComponent();
            if (itemData != null)
            {
                this.Text = "Update Action Item";
                this.itemData = itemData;
                idTextBox.Text = itemData.Id.ToString();
                nameTextBox.Text = itemData.Name;
                descriptionTextBox.Text = itemData.Description;
                selectedResource = Database.Instance.Resources.Where(x => x.Id == itemData.Resource).FirstOrDefault();
                if (selectedResource != null)
                {
                    CurrentResourceLabel.Text = selectedResource.Name;
                }
                if (!statusComboBox.Items.Contains(itemData.Status))
                {
                    statusComboBox.Items.Add(itemData.Status);
                }
                statusComboBox.SelectedItem = itemData.Status;
                expectedCompletion.Value = itemData.ExpectedCompletionDate;
                statusDescriptionTextBox.Text = itemData.StatusDescription;
            }
            else
            {
                statusComboBox.SelectedIndex = 0;
            }
            idTextBox.ReadOnly = true;
            idTextBox.Enabled = false;

            availableResourcesListBox.Items.Clear();
            foreach (string res in Database.Instance.Resources.Select(x => x.Name))
            {
                availableResourcesListBox.Items.Add(res);
            }
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
            if (string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                MessageBox.Show("Must enter a name");
                return;
            }
            if (itemData == null)
            {
                itemData = Database.NewItem<ActionItemData>(nameTextBox.Text, descriptionTextBox.Text);
            }
            itemData.Name = nameTextBox.Text;
            itemData.Description = descriptionTextBox.Text;
            itemData.SetResource(selectedResource);
            itemData.ExpectedCompletionDate = expectedCompletion.Value;
            itemData.Status = statusComboBox.Text;
            itemData.StatusDescription = statusDescriptionTextBox.Text;
            Database.Save();
            this.Close();
        }

        private void AddResourceButton_Click(object sender, EventArgs e)
        {
            if (selectedResource != null)
            {
                MessageBox.Show("Can only assign 1 resource");
                return;
            }

            if (availableResourcesListBox.SelectedItem == null)
            {
                MessageBox.Show("Must select a resource");
                return;
            }

            string selected = availableResourcesListBox.SelectedItem as string;
            selectedResource = Database.Instance.Resources.Where(x => x.Name == selected).FirstOrDefault();
            if (selectedResource == null)
            {
                MessageBox.Show("Hmm, weird DB error");
                return;
            }
            CurrentResourceLabel.Text = selected;

        }

        private void RemoveResourceButton_Click(object sender, EventArgs e)
        {
            CurrentResourceLabel.Text = "None";
            selectedResource = null;
        }
    }
}
