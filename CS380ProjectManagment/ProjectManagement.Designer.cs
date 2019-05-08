namespace CS380ProjectManagment
{
    partial class ProjectManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.projectManagementTabControl = new System.Windows.Forms.TabControl();
            this.TasksPage = new System.Windows.Forms.TabPage();
            this.actionItemsPage = new System.Windows.Forms.TabPage();
            this.deliverablesTab = new System.Windows.Forms.TabPage();
            this.resourcesTab = new System.Windows.Forms.TabPage();
            this.issuesTab = new System.Windows.Forms.TabPage();
            this.decisionsPage = new System.Windows.Forms.TabPage();
            this.projectManagementTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // projectManagementTabControl
            // 
            this.projectManagementTabControl.Controls.Add(this.TasksPage);
            this.projectManagementTabControl.Controls.Add(this.actionItemsPage);
            this.projectManagementTabControl.Controls.Add(this.deliverablesTab);
            this.projectManagementTabControl.Controls.Add(this.resourcesTab);
            this.projectManagementTabControl.Controls.Add(this.issuesTab);
            this.projectManagementTabControl.Controls.Add(this.decisionsPage);
            this.projectManagementTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.projectManagementTabControl.Location = new System.Drawing.Point(0, 0);
            this.projectManagementTabControl.Name = "projectManagementTabControl";
            this.projectManagementTabControl.SelectedIndex = 0;
            this.projectManagementTabControl.Size = new System.Drawing.Size(974, 936);
            this.projectManagementTabControl.TabIndex = 0;
            // 
            // TasksPage
            // 
            this.TasksPage.Location = new System.Drawing.Point(8, 39);
            this.TasksPage.Name = "TasksPage";
            this.TasksPage.Padding = new System.Windows.Forms.Padding(3);
            this.TasksPage.Size = new System.Drawing.Size(1375, 889);
            this.TasksPage.TabIndex = 0;
            this.TasksPage.Text = "Tasks";
            this.TasksPage.UseVisualStyleBackColor = true;
            // 
            // actionItemsPage
            // 
            this.actionItemsPage.Location = new System.Drawing.Point(8, 39);
            this.actionItemsPage.Name = "actionItemsPage";
            this.actionItemsPage.Padding = new System.Windows.Forms.Padding(3);
            this.actionItemsPage.Size = new System.Drawing.Size(1375, 889);
            this.actionItemsPage.TabIndex = 1;
            this.actionItemsPage.Text = "Action Items";
            this.actionItemsPage.UseVisualStyleBackColor = true;
            // 
            // deliverablesTab
            // 
            this.deliverablesTab.Location = new System.Drawing.Point(8, 39);
            this.deliverablesTab.Name = "deliverablesTab";
            this.deliverablesTab.Padding = new System.Windows.Forms.Padding(3);
            this.deliverablesTab.Size = new System.Drawing.Size(1375, 889);
            this.deliverablesTab.TabIndex = 2;
            this.deliverablesTab.Text = "Deliverables";
            this.deliverablesTab.UseVisualStyleBackColor = true;
            // 
            // resourcesTab
            // 
            this.resourcesTab.Location = new System.Drawing.Point(8, 39);
            this.resourcesTab.Name = "resourcesTab";
            this.resourcesTab.Padding = new System.Windows.Forms.Padding(3);
            this.resourcesTab.Size = new System.Drawing.Size(1375, 889);
            this.resourcesTab.TabIndex = 3;
            this.resourcesTab.Text = "Resources";
            this.resourcesTab.UseVisualStyleBackColor = true;
            // 
            // issuesTab
            // 
            this.issuesTab.Location = new System.Drawing.Point(8, 39);
            this.issuesTab.Name = "issuesTab";
            this.issuesTab.Padding = new System.Windows.Forms.Padding(3);
            this.issuesTab.Size = new System.Drawing.Size(1375, 889);
            this.issuesTab.TabIndex = 4;
            this.issuesTab.Text = "Issues";
            this.issuesTab.UseVisualStyleBackColor = true;
            // 
            // decisionsPage
            // 
            this.decisionsPage.Location = new System.Drawing.Point(8, 39);
            this.decisionsPage.Name = "decisionsPage";
            this.decisionsPage.Padding = new System.Windows.Forms.Padding(3);
            this.decisionsPage.Size = new System.Drawing.Size(958, 889);
            this.decisionsPage.TabIndex = 5;
            this.decisionsPage.Text = "Decisions";
            this.decisionsPage.UseVisualStyleBackColor = true;
            // 
            // ProjectManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 936);
            this.Controls.Add(this.projectManagementTabControl);
            this.Name = "ProjectManagement";
            this.Text = "Project Management";
            this.projectManagementTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl projectManagementTabControl;
        private System.Windows.Forms.TabPage TasksPage;
        private System.Windows.Forms.TabPage actionItemsPage;
        private System.Windows.Forms.TabPage deliverablesTab;
        private System.Windows.Forms.TabPage resourcesTab;
        private System.Windows.Forms.TabPage issuesTab;
        private System.Windows.Forms.TabPage decisionsPage;
    }
}