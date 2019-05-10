using CS380ProjectManagment.ActionItems;
using CS380ProjectManagment.UtilForms;
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
    public partial class ProjectManagement : Form
    {
        public ProjectManagement()
        {
            InitializeComponent();

            var taskPanel = new BasePanel<TaskData>(TasksPage.Text, () => Database.Instance.Tasks, () => new TaskCreationForm(), 
                (item) =>
                {
                    var task = Database.Instance.Tasks.Where(x => x.Name == item).FirstOrDefault();
                    if (task != null)
                    {
                        return new TaskUpdateForm(task);
                    }
                    return null;
                });
            TasksPage.Controls.Add(taskPanel);
            taskPanel.Dock = DockStyle.Fill;

            var actionItemsPanel = new BasePanel<ActionItemData>(actionItemsPage.Text,
                () => Database.Instance.ActionItems, () => new AddActionItem(null), (item) =>
            {
                var actionItem = Database.Instance.ActionItems.Where(x => x.Name == item).FirstOrDefault();
                if (actionItem != null)
                {
                    return new AddActionItem(actionItem);
                }
                return null;
            });
            actionItemsPage.Controls.Add(actionItemsPanel);
            actionItemsPanel.Dock = DockStyle.Fill;

            var decisionsPanel = new BasePanel<DecisionData>(decisionsPage.Text, () => Database.Instance.Decisions, () => new AddDecision(null),
                (item) =>
                {
                    var decision = Database.Instance.Decisions.Where(x => x.Name == item).FirstOrDefault();
                    if (decision != null)
                    {
                        return new AddDecision(decision);
                    }
                    return null;
                });
            decisionsPage.Controls.Add(decisionsPanel);
            decisionsPanel.Dock = DockStyle.Fill;

            var resourcesPanel = new BasePanel<ResourceData>(resourcesTab.Text, () => Database.Instance.Resources, () => new AddResource(null),
                (item) =>
                {
                    var resource = Database.Instance.Resources.Where(x => x.Name == item).FirstOrDefault();
                    if (resource != null)
                    {
                        return new AddResource(resource);
                    }
                    return null;
                });
            resourcesTab.Controls.Add(resourcesPanel);
            resourcesPanel.Dock = DockStyle.Fill;

            var deliverablesPanel = new BasePanel<DeliverableData>(deliverablesTab.Text, () => Database.Instance.Deliverables,
                    () => new AddDeliverable(null), (item) =>
                    {
                        var deliverable = Database.Instance.Deliverables.Where(x => x.Name == item).FirstOrDefault();
                        if (deliverable != null)
                        {
                            return new AddDeliverable(deliverable);
                        }
                        return null;
                    });
            deliverablesTab.Controls.Add(deliverablesPanel);
            deliverablesPanel.Dock = DockStyle.Fill;

            var issuesPanel = new BasePanel<IssueData>(issuesTab.Text, () => Database.Instance.Issues, () => new NewIssue(null),
                (item) =>
                {
                    var issue = Database.Instance.Issues.Where(x => x.Name == item).FirstOrDefault();
                    if (issue != null)
                    {
                        return new NewIssue(issue);
                    }
                    return null;
                });
            issuesTab.Controls.Add(issuesPanel);
            issuesPanel.Dock = DockStyle.Fill;
        }

        public static void NotImplementedMessageBox()
        {
            MessageBox.Show("This functionality is not currently implemented");
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();
            about.Show();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var basePanel = TasksPage.Controls.OfType<BasePanel<TaskData>>().First();
            basePanel.CreateButtonHandler(basePanel.CreateButton, EventArgs.Empty);
        }
    }
}
