namespace CS380ProjectManagment
{
    partial class NewIssue
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
            this.label1 = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.priorityComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.severityComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dateRaisedPicker = new System.Windows.Forms.DateTimePicker();
            this.dateAssignedPicker = new System.Windows.Forms.DateTimePicker();
            this.expectedCompletionDatePicker = new System.Windows.Forms.DateTimePicker();
            this.actualCompletitonDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.statusDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.associateActionItemButton = new System.Windows.Forms.Button();
            this.associateDecisionButton = new System.Windows.Forms.Button();
            this.unassociateActionItemButton = new System.Windows.Forms.Button();
            this.unassociateDecisionButton = new System.Windows.Forms.Button();
            this.actionItemsListBox = new System.Windows.Forms.ListBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.currentActionItemsListBox = new System.Windows.Forms.ListBox();
            this.decisionsListBox = new System.Windows.Forms.ListBox();
            this.currentDecisionsListBox = new System.Windows.Forms.ListBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lastUpdatePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Issue Id";
            // 
            // idTextBox
            // 
            this.idTextBox.Enabled = false;
            this.idTextBox.Location = new System.Drawing.Point(116, 19);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(142, 20);
            this.idTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Issue Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(117, 60);
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(141, 20);
            this.nameTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(331, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Issue Description";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(322, 45);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(176, 129);
            this.descriptionTextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Priority";
            // 
            // priorityComboBox
            // 
            this.priorityComboBox.FormattingEnabled = true;
            this.priorityComboBox.Items.AddRange(new object[] {
            "High",
            "Medium",
            "Low",
            "None"});
            this.priorityComboBox.Location = new System.Drawing.Point(117, 103);
            this.priorityComboBox.Name = "priorityComboBox";
            this.priorityComboBox.Size = new System.Drawing.Size(141, 21);
            this.priorityComboBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Severity";
            // 
            // severityComboBox
            // 
            this.severityComboBox.FormattingEnabled = true;
            this.severityComboBox.Items.AddRange(new object[] {
            "Critical",
            "High",
            "Medium",
            "Low",
            "Minor",
            "None"});
            this.severityComboBox.Location = new System.Drawing.Point(117, 153);
            this.severityComboBox.Name = "severityComboBox";
            this.severityComboBox.Size = new System.Drawing.Size(141, 21);
            this.severityComboBox.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(506, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Date Raised";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(506, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Date Assigned";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(504, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Expected Completion Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(504, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Actual Completion Date";
            // 
            // dateRaisedPicker
            // 
            this.dateRaisedPicker.Enabled = false;
            this.dateRaisedPicker.Location = new System.Drawing.Point(643, 22);
            this.dateRaisedPicker.Name = "dateRaisedPicker";
            this.dateRaisedPicker.Size = new System.Drawing.Size(200, 20);
            this.dateRaisedPicker.TabIndex = 15;
            // 
            // dateAssignedPicker
            // 
            this.dateAssignedPicker.Location = new System.Drawing.Point(643, 60);
            this.dateAssignedPicker.Name = "dateAssignedPicker";
            this.dateAssignedPicker.Size = new System.Drawing.Size(200, 20);
            this.dateAssignedPicker.TabIndex = 16;
            // 
            // expectedCompletionDatePicker
            // 
            this.expectedCompletionDatePicker.Location = new System.Drawing.Point(643, 103);
            this.expectedCompletionDatePicker.Name = "expectedCompletionDatePicker";
            this.expectedCompletionDatePicker.Size = new System.Drawing.Size(200, 20);
            this.expectedCompletionDatePicker.TabIndex = 17;
            // 
            // actualCompletitonDatePicker
            // 
            this.actualCompletitonDatePicker.Location = new System.Drawing.Point(643, 154);
            this.actualCompletitonDatePicker.Name = "actualCompletitonDatePicker";
            this.actualCompletitonDatePicker.Size = new System.Drawing.Size(200, 20);
            this.actualCompletitonDatePicker.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(43, 199);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Status";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(43, 245);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Status Description";
            // 
            // statusDescriptionTextBox
            // 
            this.statusDescriptionTextBox.Location = new System.Drawing.Point(46, 274);
            this.statusDescriptionTextBox.Multiline = true;
            this.statusDescriptionTextBox.Name = "statusDescriptionTextBox";
            this.statusDescriptionTextBox.Size = new System.Drawing.Size(142, 144);
            this.statusDescriptionTextBox.TabIndex = 22;
            // 
            // statusComboBox
            // 
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Items.AddRange(new object[] {
            "Open",
            "Closed",
            "In Progress",
            "Hold",
            "Complete",
            "None"});
            this.statusComboBox.Location = new System.Drawing.Point(116, 199);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(142, 21);
            this.statusComboBox.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(210, 240);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(111, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Available Action Items";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(509, 240);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "Available Decisions";
            // 
            // associateActionItemButton
            // 
            this.associateActionItemButton.Location = new System.Drawing.Point(272, 451);
            this.associateActionItemButton.Name = "associateActionItemButton";
            this.associateActionItemButton.Size = new System.Drawing.Size(176, 23);
            this.associateActionItemButton.TabIndex = 30;
            this.associateActionItemButton.Text = "Associate Action Item";
            this.associateActionItemButton.UseVisualStyleBackColor = true;
            this.associateActionItemButton.Click += new System.EventHandler(this.AssociateActionItemButton_Click);
            // 
            // associateDecisionButton
            // 
            this.associateDecisionButton.Location = new System.Drawing.Point(537, 451);
            this.associateDecisionButton.Name = "associateDecisionButton";
            this.associateDecisionButton.Size = new System.Drawing.Size(246, 23);
            this.associateDecisionButton.TabIndex = 31;
            this.associateDecisionButton.Text = "Associate Decision";
            this.associateDecisionButton.UseVisualStyleBackColor = true;
            this.associateDecisionButton.Click += new System.EventHandler(this.AssociateDecisionButton_Click);
            // 
            // unassociateActionItemButton
            // 
            this.unassociateActionItemButton.Location = new System.Drawing.Point(272, 490);
            this.unassociateActionItemButton.Name = "unassociateActionItemButton";
            this.unassociateActionItemButton.Size = new System.Drawing.Size(176, 23);
            this.unassociateActionItemButton.TabIndex = 32;
            this.unassociateActionItemButton.Text = "Un-Associate Action Item";
            this.unassociateActionItemButton.UseVisualStyleBackColor = true;
            this.unassociateActionItemButton.Click += new System.EventHandler(this.UnassociateActionItemButton_Click);
            // 
            // unassociateDecisionButton
            // 
            this.unassociateDecisionButton.Location = new System.Drawing.Point(537, 490);
            this.unassociateDecisionButton.Name = "unassociateDecisionButton";
            this.unassociateDecisionButton.Size = new System.Drawing.Size(246, 23);
            this.unassociateDecisionButton.TabIndex = 33;
            this.unassociateDecisionButton.Text = "Un-Associate Decision";
            this.unassociateDecisionButton.UseVisualStyleBackColor = true;
            this.unassociateDecisionButton.Click += new System.EventHandler(this.UnassociateDecisionButton_Click);
            // 
            // actionItemsListBox
            // 
            this.actionItemsListBox.FormattingEnabled = true;
            this.actionItemsListBox.Location = new System.Drawing.Point(212, 269);
            this.actionItemsListBox.Margin = new System.Windows.Forms.Padding(2);
            this.actionItemsListBox.Name = "actionItemsListBox";
            this.actionItemsListBox.Size = new System.Drawing.Size(128, 160);
            this.actionItemsListBox.TabIndex = 34;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(821, 468);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 76;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(821, 497);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 75;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // currentActionItemsListBox
            // 
            this.currentActionItemsListBox.FormattingEnabled = true;
            this.currentActionItemsListBox.Location = new System.Drawing.Point(360, 269);
            this.currentActionItemsListBox.Margin = new System.Windows.Forms.Padding(2);
            this.currentActionItemsListBox.Name = "currentActionItemsListBox";
            this.currentActionItemsListBox.Size = new System.Drawing.Size(128, 160);
            this.currentActionItemsListBox.TabIndex = 34;
            // 
            // decisionsListBox
            // 
            this.decisionsListBox.FormattingEnabled = true;
            this.decisionsListBox.Location = new System.Drawing.Point(512, 269);
            this.decisionsListBox.Margin = new System.Windows.Forms.Padding(2);
            this.decisionsListBox.Name = "decisionsListBox";
            this.decisionsListBox.Size = new System.Drawing.Size(128, 160);
            this.decisionsListBox.TabIndex = 34;
            // 
            // currentDecisionsListBox
            // 
            this.currentDecisionsListBox.FormattingEnabled = true;
            this.currentDecisionsListBox.Location = new System.Drawing.Point(675, 269);
            this.currentDecisionsListBox.Margin = new System.Windows.Forms.Padding(2);
            this.currentDecisionsListBox.Name = "currentDecisionsListBox";
            this.currentDecisionsListBox.Size = new System.Drawing.Size(128, 160);
            this.currentDecisionsListBox.TabIndex = 34;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(358, 240);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(102, 13);
            this.label15.TabIndex = 25;
            this.label15.Text = "Current Action Items";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(672, 240);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(90, 13);
            this.label16.TabIndex = 26;
            this.label16.Text = "Current Decisions";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(506, 190);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Last Update Date";
            // 
            // lastUpdatePicker
            // 
            this.lastUpdatePicker.Enabled = false;
            this.lastUpdatePicker.Location = new System.Drawing.Point(645, 188);
            this.lastUpdatePicker.Name = "lastUpdatePicker";
            this.lastUpdatePicker.Size = new System.Drawing.Size(200, 20);
            this.lastUpdatePicker.TabIndex = 18;
            // 
            // NewIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 530);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.currentDecisionsListBox);
            this.Controls.Add(this.decisionsListBox);
            this.Controls.Add(this.currentActionItemsListBox);
            this.Controls.Add(this.actionItemsListBox);
            this.Controls.Add(this.unassociateDecisionButton);
            this.Controls.Add(this.unassociateActionItemButton);
            this.Controls.Add(this.associateDecisionButton);
            this.Controls.Add(this.associateActionItemButton);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(this.statusDescriptionTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lastUpdatePicker);
            this.Controls.Add(this.actualCompletitonDatePicker);
            this.Controls.Add(this.expectedCompletionDatePicker);
            this.Controls.Add(this.dateAssignedPicker);
            this.Controls.Add(this.dateRaisedPicker);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.severityComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.priorityComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.label1);
            this.Name = "NewIssue";
            this.Text = "Create New Issue";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox priorityComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox severityComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateRaisedPicker;
        private System.Windows.Forms.DateTimePicker dateAssignedPicker;
        private System.Windows.Forms.DateTimePicker expectedCompletionDatePicker;
        private System.Windows.Forms.DateTimePicker actualCompletitonDatePicker;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox statusDescriptionTextBox;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button associateActionItemButton;
        private System.Windows.Forms.Button associateDecisionButton;
        private System.Windows.Forms.Button unassociateActionItemButton;
        private System.Windows.Forms.Button unassociateDecisionButton;
        private System.Windows.Forms.ListBox actionItemsListBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ListBox currentActionItemsListBox;
        private System.Windows.Forms.ListBox decisionsListBox;
        private System.Windows.Forms.ListBox currentDecisionsListBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker lastUpdatePicker;
    }
}