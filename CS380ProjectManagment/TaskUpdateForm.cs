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
    public partial class TaskUpdateForm : Form
    {
        private TaskData taskData;
        public TaskUpdateForm(TaskData taskData)
        {
            this.taskData = taskData;
            InitializeComponent();
            this.Size = new Size(this.Size.Width, (int)(this.Size.Height * 1.35));

            availableResourcesListBox.Items.Clear();
            foreach (string res in Database.Instance.Resources.Select(x => x.Name))
            {
                availableResourcesListBox.Items.Add(res);
            }

            allTasksListBox.Items.Clear();
            foreach (string res in Database.Instance.Tasks.Select(x => x.Name))
            {
                allTasksListBox.Items.Add(res);
            }

            issuesListBox.Items.Clear();
            foreach (string res in Database.Instance.Issues.Select(x => x.Name))
            {
                issuesListBox.Items.Add(res);
            }

            allTasksListBox2.Items.Clear();
            foreach (string res in Database.Instance.Tasks.Select(x => x.Name))
            {
                allTasksListBox2.Items.Add(res);
            }

            addFinishToFinishButton.Tag = finishToFinishListBox;
            removeFinishToFinishButton.Tag = finishToFinishListBox;
            addStartToStartButton.Tag = startToStartListBox;
            removeStartToStartButton.Tag = startToStartListBox;
            addStartToFinishButton.Tag = startToFinishListBox;
            removeStartToFinishButton.Tag = startToFinishListBox;
            addFinishToStartButton.Tag = finishToStartListBox;
            removeFinishToStartButton.Tag = finishToStartListBox;


            idTextBox.Text = taskData.Id.ToString();
            nameTextBox.Text = taskData.Name;
            descriptionTextBox.Text = taskData.Description;

            milestoneCheckBox.Checked = taskData.IsMilestone;

            expectedDuration.Value = taskData.ExpectedDuration;
            expectedEndDatePicker.Value = taskData.ExpectedEndDate;
            expectedStartDatePicker.Value = taskData.ExpectedStartDate;

            foreach (var res in taskData.Resources)
            {
                var item = Database.Instance.Resources.Where(x => x.Id == res).FirstOrDefault();
                if (item != null)
                {
                    currentResourcesListBox.Items.Add(item.Name);
                }
            }

            HandleTaskAdd(taskData.PredecessorTasks, predecessorListBox);
            HandleTaskAdd(taskData.FinishToFinishTasks, finishToFinishListBox);
            HandleTaskAdd(taskData.StartToStartTasks, startToStartListBox);
            HandleTaskAdd(taskData.FinishToStartTasks, finishToStartListBox);
            HandleTaskAdd(taskData.StartToFinishTasks, startToFinishListBox);

            foreach (var res in taskData.Issues)
            {
                var item = Database.Instance.Issues.Where(x => x.Id == res).FirstOrDefault();
                if (item != null)
                {
                    addedIssuesListBox.Items.Add(item.Name);
                }
            }
        }

        private void HandleTaskAdd(List<Guid> list, ListBox tasks)
        {
            foreach (var res in list)
            {
                var item = Database.Instance.Tasks.Where(x => x.Id == res).FirstOrDefault();
                if (item != null)
                {
                    tasks.Items.Add(item.Name);
                }
            }
        }

        private void HandleTaskUpdate(TaskData data, ListBox tasks, List<Guid> guidList)
        {
            guidList.Clear();
            foreach (string name in tasks.Items)
            {
                data.AddTask(name, guidList);
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                MessageBox.Show("Must enter a name");
                return;
            }
            taskData.IsMilestone = milestoneCheckBox.Checked;
            taskData.Description = descriptionTextBox.Text;
            taskData.Resources.Clear();
            foreach (string name in currentResourcesListBox.Items)
            {
                taskData.AddResource(name);
            }
            taskData.ExpectedStartDate = expectedStartDatePicker.Value;
            taskData.ExpectedEndDate = expectedEndDatePicker.Value;
            taskData.ExpectedDuration = (int)expectedDuration.Value;

            HandleTaskUpdate(taskData, predecessorListBox, taskData.PredecessorTasks);
            HandleTaskUpdate(taskData, startToFinishListBox, taskData.StartToFinishTasks);
            HandleTaskUpdate(taskData, startToStartListBox, taskData.StartToStartTasks);
            HandleTaskUpdate(taskData, finishToFinishListBox, taskData.FinishToFinishTasks);
            HandleTaskUpdate(taskData, finishToStartListBox, taskData.FinishToStartTasks);
            Database.Save();
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddResourceButton_Click(object sender, EventArgs e)
        {
            if (availableResourcesListBox.SelectedItem == null)
            {
                MessageBox.Show("Must select a resource");
                return;
            }

            string selected = availableResourcesListBox.SelectedItem as string;
            currentResourcesListBox.Items.Add(selected);
        }

        private void RemoveResourceButton_Click(object sender, EventArgs e)
        {
            if (currentResourcesListBox.SelectedItem == null)
            {
                MessageBox.Show("Must select a resource");
                return;
            }

            string selected = currentResourcesListBox.SelectedItem as string;
            currentResourcesListBox.Items.Remove(selected);
        }

        private void AddPredecessorButton_Click(object sender, EventArgs e)
        {
            if (allTasksListBox.SelectedItem == null)
            {
                MessageBox.Show("Must select a Task");
                return;
            }

            string selected = allTasksListBox.SelectedItem as string;
            predecessorListBox.Items.Add(selected);
        }

        private void RemovePredecessorButton_Click(object sender, EventArgs e)
        {
            if (predecessorListBox.SelectedItem == null)
            {
                MessageBox.Show("Must select a Task");
                return;
            }

            string selected = predecessorListBox.SelectedItem as string;
            predecessorListBox.Items.Remove(selected);
        }

        private void SuccessorAddButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (allTasksListBox2.SelectedItem == null)
            {
                MessageBox.Show("Must select a Task");
                return;
            }

            string selected = allTasksListBox2.SelectedItem as string;
            ((ListBox)button.Tag).Items.Add(selected);
        }

        private void SuccessorRemoveButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            var listBox = (ListBox)button.Tag;
            if (listBox.SelectedItem == null)
            {
                MessageBox.Show("Must select a Task");
                return;
            }

            string selected = listBox.SelectedItem as string;
            listBox.Items.Remove(selected);
        }

        private void AddIssueButton_Click(object sender, EventArgs e)
        {
            if (issuesListBox.SelectedItem == null)
            {
                MessageBox.Show("Must select a resource");
                return;
            }

            string selected = issuesListBox.SelectedItem as string;
            addedIssuesListBox.Items.Add(selected);
        }

        private void RemoveIssueButton_Click(object sender, EventArgs e)
        {
            if (addedIssuesListBox.SelectedItem == null)
            {
                MessageBox.Show("Must select a resource");
                return;
            }

            string selected = addedIssuesListBox.SelectedItem as string;
            addedIssuesListBox.Items.Remove(selected);
        }

        private void CreateNewIssueButton_Click(object sender, EventArgs e)
        {
            NewIssue newIssue = new NewIssue();
            newIssue.FormClosed += (o, e2) => {
                issuesListBox.Items.Clear();
                foreach (string res in Database.Instance.Issues.Select(x => x.Name))
                {
                    issuesListBox.Items.Add(res);
                }
            };
            newIssue.Show();
        }
    }
}
