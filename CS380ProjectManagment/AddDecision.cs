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
    public partial class AddDecision : Form
    {
        private DecisionData decisionData;
        public AddDecision(DecisionData decisionData)
        {
            this.decisionData = decisionData;
            InitializeComponent();
            this.AddSaveHandler(saveButton);
            this.AddCloseHandler(cancelButton);

            decisionMakerComboBox.Items.Clear();
            foreach (string res in Database.Instance.Resources.Select(x => x.Name))
            {
                decisionMakerComboBox.Items.Add(res);
            }

            if (decisionMakerComboBox.Items.Count > 0) {
                decisionMakerComboBox.SelectedIndex = 0;
            }

            if (decisionData != null)
            {
                this.Text = "Update Decision";
                dateCreatedPicker.Enabled = false;
                idTextBox.Text = decisionData.Id.ToString();
                nameTextBox.Text = decisionData.Name;
                priorityComboBox.Text = decisionData.Priority;
                impactComboBox.Text = decisionData.Impact;
                dateCreatedPicker.Value = decisionData.DateCreated;
                dateNeededPicker.Value = decisionData.DateNeeded;
                dateMadePicker.Value = decisionData.DateMade;
                if (decisionMakerComboBox.Items.Contains(decisionData.DecisionMaker))
                {
                    decisionMakerComboBox.SelectedItem = decisionData.DecisionMaker;
                }
                expectedCompletionDatePicker.Value = decisionData.ExpectedCompletionDate;
                actualCompletionDatePicker.Value = decisionData.ActualCompletionDate;
                updateDatePicker.Value = decisionData.UpdateDate;
                statusTextBox.Text = decisionData.Status;
                statusDescriptionTextBox.Text = decisionData.StatusDescription;
                meetingNotesTextBox.Lines = decisionData.MeetingNotes.ToArray();

                foreach (var res in decisionData.AssociatedTasks)
                {
                    var item = Database.Instance.Tasks.Where(x => x.Id == res).FirstOrDefault();
                    if (item != null)
                    {
                        associatedTasksListBox.Items.Add(item.Name);
                    }
                }
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
            if (decisionData == null)
            {
                decisionData = Database.NewItem<DecisionData>(nameTextBox.Text, descriptionTextBox.Text);
                decisionData.DateCreated = DateTime.Now;
            }
            decisionData.Name = nameTextBox.Text;
            decisionData.Description = nameTextBox.Text;
            decisionData.Priority = priorityComboBox.Text;
            decisionData.Impact = impactComboBox.Text;
            decisionData.DateNeeded = dateNeededPicker.Value;
            decisionData.DateMade = dateMadePicker.Value;
            decisionData.DecisionMaker = Database.Instance.Resources.Where(x => x.Name == decisionMakerComboBox.Text).FirstOrDefault()?.Id ?? Guid.Empty;
            decisionData.ExpectedCompletionDate = expectedCompletionDatePicker.Value;
            decisionData.ActualCompletionDate = actualCompletionDatePicker.Value;
            decisionData.UpdateDate = DateTime.Now;
            decisionData.Status = statusTextBox.Text;
            decisionData.StatusDescription = statusDescriptionTextBox.Text;
            decisionData.MeetingNotes = meetingNotesTextBox.Lines.ToList();

            decisionData.AssociatedTasks.Clear();
            foreach (string name in associatedTasksListBox.Items)
            {
                decisionData.AddTask(name);
            }
            
            Database.Save();
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddTaskButton_Click(object sender, EventArgs e)
        {

        }

        private void RemoveTaskButton_Click(object sender, EventArgs e)
        {

        }
    }
}
