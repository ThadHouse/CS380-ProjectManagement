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
    public partial class AddDeliverable : Form
    {
        private DeliverableData deliverableData;
        public AddDeliverable(DeliverableData deliverableData)
        {
            InitializeComponent();
            this.AddSaveHandler(saveButton);
            this.AddCloseHandler(cancelButton);

            this.deliverableData = deliverableData;

            if (deliverableData != null)
            {
                this.Text = "Update Deliverable";
                idTextBox.Text = deliverableData.Id.ToString();
                nameTextBox.Text = deliverableData.Name;
                descriptionTextBox.Text = deliverableData.Description;
                dueDatePicker.Value = deliverableData.DueDate;

                foreach (var res in deliverableData.AssociatedResources)
                {
                    var item = Database.Instance.Resources.Where(x => x.Id == res).FirstOrDefault();
                    if (item != null)
                    {
                        associatedResourcesListBox.Items.Add(item.Name);
                    }
                }

                foreach (var res in deliverableData.AssociatedTasks)
                {
                    var item = Database.Instance.Tasks.Where(x => x.Id == res).FirstOrDefault();
                    if (item != null)
                    {
                        associatedTasksListBox.Items.Add(item.Name);
                    }
                }
            }

            resourcesListBox.Items.Clear();
            foreach (string res in Database.Instance.Resources.Select(x => x.Name))
            {
                resourcesListBox.Items.Add(res);
            }

            tasksListBox.Items.Clear();
            foreach (string res in Database.Instance.Tasks.Select(x => x.Name))
            {
                tasksListBox.Items.Add(res);
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                MessageBox.Show("Must enter a name");
                return;
            }
            if (deliverableData == null)
            {
                deliverableData = Database.NewItem<DeliverableData>(nameTextBox.Text, descriptionTextBox.Text);
            }
            deliverableData.Name = nameTextBox.Text;
            deliverableData.Description = descriptionTextBox.Text;
            deliverableData.DueDate = dueDatePicker.Value;

            deliverableData.AssociatedResources.Clear();
            foreach (string name in associatedResourcesListBox.Items)
            {
                deliverableData.AddResource(name);
            }

            deliverableData.AssociatedTasks.Clear();
            foreach (string name in associatedTasksListBox.Items)
            {
                deliverableData.AddTask(name);
            }
            Database.Save();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddTasksButton_Click(object sender, EventArgs e)
        {
            if (tasksListBox.SelectedItem == null)
            {
                MessageBox.Show("Must select a Task");
                return;
            }

            string selected = tasksListBox.SelectedItem as string;
            associatedTasksListBox.Items.Add(selected);
        }

        private void RemoveTasksButton_Click(object sender, EventArgs e)
        {
            if (associatedTasksListBox.SelectedItem == null)
            {
                MessageBox.Show("Must select a Task");
                return;
            }

            string selected = associatedTasksListBox.SelectedItem as string;
            associatedTasksListBox.Items.Remove(selected);
        }

        private void AddResourcesButton_Click(object sender, EventArgs e)
        {
            if (resourcesListBox.SelectedItem == null)
            {
                MessageBox.Show("Must select a resource");
                return;
            }

            string selected = resourcesListBox.SelectedItem as string;
            associatedResourcesListBox.Items.Add(selected);
        }

        private void RemoveResourcesButton_Click(object sender, EventArgs e)
        {
            if (associatedResourcesListBox.SelectedItem == null)
            {
                MessageBox.Show("Must select a resource");
                return;
            }

            string selected = associatedResourcesListBox.SelectedItem as string;
            associatedResourcesListBox.Items.Remove(selected);
        }
    }
}
