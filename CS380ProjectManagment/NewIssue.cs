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
        private IssueData issueData;
        public NewIssue(IssueData issueData)
        {
            this.issueData = issueData;
            InitializeComponent();
            this.Size = new Size(this.Size.Width, (int)(this.Size.Height * 1.15));

            lastUpdatePicker.Value = DateTime.Now;

            if (issueData == null)
            {
                dateRaisedPicker.Value = DateTime.Now;
            }
            else
            {
                this.Text = "Update Issue";
                idTextBox.Text = issueData.Id.ToString();
                nameTextBox.Text = issueData.Name;
                priorityComboBox.Text = issueData.Priority;
                severityComboBox.Text = issueData.Severity;
                statusComboBox.Text = issueData.Status;
                statusDescriptionTextBox.Text = issueData.StatusDescription;
                descriptionTextBox.Text = issueData.Description;

                foreach (var res in issueData.ActionItems)
                {
                    var item = Database.Instance.ActionItems.Where(x => x.Id == res).FirstOrDefault();
                    if (item != null)
                    {
                        currentActionItemsListBox.Items.Add(item.Name);
                    }
                }

                foreach (var res in issueData.Decisions)
                {
                    var item = Database.Instance.Decisions.Where(x => x.Id == res).FirstOrDefault();
                    if (item != null)
                    {
                        currentDecisionsListBox.Items.Add(item.Name);
                    }
                }

                expectedCompletionDatePicker.Value = issueData.ExpectedCompletionDate;
                dateRaisedPicker.Value = issueData.DateRaised;
                dateAssignedPicker.Value = issueData.DateAssigned;
                actualCompletitonDatePicker.Value = issueData.ActualCompletionDate;
                lastUpdatePicker.Value = issueData.LastUpdateDate;
            }

            actionItemsListBox.Items.Clear();
            foreach (string res in Database.Instance.ActionItems.Select(x => x.Name))
            {
                actionItemsListBox.Items.Add(res);
            }

            decisionsListBox.Items.Clear();
            foreach (string res in Database.Instance.Decisions.Select(x => x.Name))
            {
                decisionsListBox.Items.Add(res);
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                MessageBox.Show("Must enter a name");
                return;
            }
            if (issueData == null)
            {
                issueData = Database.NewItem<IssueData>(nameTextBox.Text, descriptionTextBox.Text);
            }
            issueData.Name = nameTextBox.Text;
            issueData.Description = descriptionTextBox.Text;
            issueData.DateAssigned = dateAssignedPicker.Value;
            issueData.DateRaised = dateRaisedPicker.Value;
            issueData.ActualCompletionDate = actualCompletitonDatePicker.Value;
            issueData.ExpectedCompletionDate = expectedCompletionDatePicker.Value;
            issueData.LastUpdateDate = DateTime.Now;
            issueData.Status = statusComboBox.Text;
            issueData.StatusDescription = statusDescriptionTextBox.Text;
            issueData.Priority = priorityComboBox.Text;
            issueData.Severity = severityComboBox.Text;

            issueData.ActionItems.Clear();
            foreach (string ai in currentActionItemsListBox.Items)
            {
                issueData.AddActionItem(ai);
            }

            issueData.Decisions.Clear();
            foreach (string ai in currentDecisionsListBox.Items)
            {
                issueData.AddDecision(ai);
            }
            Database.Save();
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AssociateActionItemButton_Click(object sender, EventArgs e)
        {
            if (actionItemsListBox.SelectedItem == null)
            {
                MessageBox.Show("Must select an Action Item");
                return;
            }

            string selected = actionItemsListBox.SelectedItem as string;
            currentActionItemsListBox.Items.Add(selected);
        }

        private void UnassociateActionItemButton_Click(object sender, EventArgs e)
        {
            if (currentActionItemsListBox.SelectedItem == null)
            {
                MessageBox.Show("Must select an Action Item");
                return;
            }

            string selected = currentActionItemsListBox.SelectedItem as string;
            currentActionItemsListBox.Items.Remove(selected);
        }

        private void AssociateDecisionButton_Click(object sender, EventArgs e)
        {
            if (decisionsListBox.SelectedItem == null)
            {
                MessageBox.Show("Must select a Decision");
                return;
            }

            string selected = decisionsListBox.SelectedItem as string;
            currentDecisionsListBox.Items.Add(selected);
        }

        private void UnassociateDecisionButton_Click(object sender, EventArgs e)
        {
            if (currentDecisionsListBox.SelectedItem == null)
            {
                MessageBox.Show("Must select a resource");
                return;
            }

            string selected = currentDecisionsListBox.SelectedItem as string;
            currentDecisionsListBox.Items.Remove(selected);
        }
    }
}
