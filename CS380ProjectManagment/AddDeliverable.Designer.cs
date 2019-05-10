namespace CS380ProjectManagment
{
    partial class AddDeliverable
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
            this.dueDatePicker = new System.Windows.Forms.DateTimePicker();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addTasksButton = new System.Windows.Forms.Button();
            this.removeTasksButton = new System.Windows.Forms.Button();
            this.addResourcesButton = new System.Windows.Forms.Button();
            this.removeResourcesButton = new System.Windows.Forms.Button();
            this.tasksListBox = new System.Windows.Forms.ListBox();
            this.associatedTasksListBox = new System.Windows.Forms.ListBox();
            this.resourcesListBox = new System.Windows.Forms.ListBox();
            this.associatedResourcesListBox = new System.Windows.Forms.ListBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dueDatePicker
            // 
            this.dueDatePicker.Location = new System.Drawing.Point(96, 126);
            this.dueDatePicker.Name = "dueDatePicker";
            this.dueDatePicker.Size = new System.Drawing.Size(200, 20);
            this.dueDatePicker.TabIndex = 18;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(234, 31);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(179, 20);
            this.nameTextBox.TabIndex = 17;
            // 
            // idTextBox
            // 
            this.idTextBox.Enabled = false;
            this.idTextBox.Location = new System.Drawing.Point(73, 31);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 16;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(463, 55);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(280, 129);
            this.descriptionTextBox.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(460, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Task Id:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Due Date:";
            // 
            // addTasksButton
            // 
            this.addTasksButton.Location = new System.Drawing.Point(168, 269);
            this.addTasksButton.Name = "addTasksButton";
            this.addTasksButton.Size = new System.Drawing.Size(75, 23);
            this.addTasksButton.TabIndex = 24;
            this.addTasksButton.Text = ">>";
            this.addTasksButton.UseVisualStyleBackColor = true;
            this.addTasksButton.Click += new System.EventHandler(this.AddTasksButton_Click);
            // 
            // removeTasksButton
            // 
            this.removeTasksButton.Location = new System.Drawing.Point(168, 333);
            this.removeTasksButton.Name = "removeTasksButton";
            this.removeTasksButton.Size = new System.Drawing.Size(75, 23);
            this.removeTasksButton.TabIndex = 25;
            this.removeTasksButton.Text = "<<";
            this.removeTasksButton.UseVisualStyleBackColor = true;
            this.removeTasksButton.Click += new System.EventHandler(this.RemoveTasksButton_Click);
            // 
            // addResourcesButton
            // 
            this.addResourcesButton.Location = new System.Drawing.Point(602, 269);
            this.addResourcesButton.Name = "addResourcesButton";
            this.addResourcesButton.Size = new System.Drawing.Size(75, 23);
            this.addResourcesButton.TabIndex = 26;
            this.addResourcesButton.Text = ">>";
            this.addResourcesButton.UseVisualStyleBackColor = true;
            this.addResourcesButton.Click += new System.EventHandler(this.AddResourcesButton_Click);
            // 
            // removeResourcesButton
            // 
            this.removeResourcesButton.Location = new System.Drawing.Point(602, 333);
            this.removeResourcesButton.Name = "removeResourcesButton";
            this.removeResourcesButton.Size = new System.Drawing.Size(75, 23);
            this.removeResourcesButton.TabIndex = 27;
            this.removeResourcesButton.Text = "<<";
            this.removeResourcesButton.UseVisualStyleBackColor = true;
            this.removeResourcesButton.Click += new System.EventHandler(this.RemoveResourcesButton_Click);
            // 
            // tasksListBox
            // 
            this.tasksListBox.FormattingEnabled = true;
            this.tasksListBox.Location = new System.Drawing.Point(28, 233);
            this.tasksListBox.Margin = new System.Windows.Forms.Padding(2);
            this.tasksListBox.Name = "tasksListBox";
            this.tasksListBox.Size = new System.Drawing.Size(126, 160);
            this.tasksListBox.TabIndex = 32;
            // 
            // associatedTasksListBox
            // 
            this.associatedTasksListBox.FormattingEnabled = true;
            this.associatedTasksListBox.Location = new System.Drawing.Point(261, 233);
            this.associatedTasksListBox.Margin = new System.Windows.Forms.Padding(2);
            this.associatedTasksListBox.Name = "associatedTasksListBox";
            this.associatedTasksListBox.Size = new System.Drawing.Size(136, 160);
            this.associatedTasksListBox.TabIndex = 33;
            // 
            // resourcesListBox
            // 
            this.resourcesListBox.FormattingEnabled = true;
            this.resourcesListBox.Location = new System.Drawing.Point(450, 233);
            this.resourcesListBox.Margin = new System.Windows.Forms.Padding(2);
            this.resourcesListBox.Name = "resourcesListBox";
            this.resourcesListBox.Size = new System.Drawing.Size(126, 160);
            this.resourcesListBox.TabIndex = 32;
            // 
            // associatedResourcesListBox
            // 
            this.associatedResourcesListBox.FormattingEnabled = true;
            this.associatedResourcesListBox.Location = new System.Drawing.Point(702, 233);
            this.associatedResourcesListBox.Margin = new System.Windows.Forms.Padding(2);
            this.associatedResourcesListBox.Name = "associatedResourcesListBox";
            this.associatedResourcesListBox.Size = new System.Drawing.Size(136, 160);
            this.associatedResourcesListBox.TabIndex = 33;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(858, 399);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 77;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(858, 370);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 78;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 79;
            this.label5.Text = "Tasks";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(258, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 79;
            this.label6.Text = "Associated Tasks";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(447, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 79;
            this.label7.Text = "Resources";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(699, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 13);
            this.label8.TabIndex = 79;
            this.label8.Text = "Associated Resources";
            // 
            // AddDeliverable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 426);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.associatedResourcesListBox);
            this.Controls.Add(this.associatedTasksListBox);
            this.Controls.Add(this.resourcesListBox);
            this.Controls.Add(this.tasksListBox);
            this.Controls.Add(this.removeResourcesButton);
            this.Controls.Add(this.addResourcesButton);
            this.Controls.Add(this.removeTasksButton);
            this.Controls.Add(this.addTasksButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dueDatePicker);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "AddDeliverable";
            this.Text = "Create New Deliverable";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dueDatePicker;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addTasksButton;
        private System.Windows.Forms.Button removeTasksButton;
        private System.Windows.Forms.Button addResourcesButton;
        private System.Windows.Forms.Button removeResourcesButton;
        private System.Windows.Forms.ListBox tasksListBox;
        private System.Windows.Forms.ListBox associatedTasksListBox;
        private System.Windows.Forms.ListBox resourcesListBox;
        private System.Windows.Forms.ListBox associatedResourcesListBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}