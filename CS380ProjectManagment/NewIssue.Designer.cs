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
            this.label1.Location = new System.Drawing.Point(88, 123);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Issue Id";
            // 
            // idTextBox
            // 
            this.idTextBox.Enabled = false;
            this.idTextBox.Location = new System.Drawing.Point(232, 123);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(280, 31);
            this.idTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 202);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Issue Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(234, 202);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(278, 35);
            this.nameTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(662, 123);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Issue Description";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(644, 173);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(348, 244);
            this.descriptionTextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 285);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 25);
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
            this.priorityComboBox.Location = new System.Drawing.Point(234, 285);
            this.priorityComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.priorityComboBox.Name = "priorityComboBox";
            this.priorityComboBox.Size = new System.Drawing.Size(278, 33);
            this.priorityComboBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 387);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 25);
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
            this.severityComboBox.Location = new System.Drawing.Point(234, 381);
            this.severityComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.severityComboBox.Name = "severityComboBox";
            this.severityComboBox.Size = new System.Drawing.Size(278, 33);
            this.severityComboBox.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1012, 129);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Date Raised";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1012, 208);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "Date Assigned";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1008, 290);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(267, 25);
            this.label8.TabIndex = 12;
            this.label8.Text = "Expected Completion Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1008, 387);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(237, 25);
            this.label9.TabIndex = 13;
            this.label9.Text = "Actual Completion Date";
            // 
            // dateRaisedPicker
            // 
            this.dateRaisedPicker.Enabled = false;
            this.dateRaisedPicker.Location = new System.Drawing.Point(1286, 129);
            this.dateRaisedPicker.Margin = new System.Windows.Forms.Padding(6);
            this.dateRaisedPicker.Name = "dateRaisedPicker";
            this.dateRaisedPicker.Size = new System.Drawing.Size(396, 31);
            this.dateRaisedPicker.TabIndex = 15;
            // 
            // dateAssignedPicker
            // 
            this.dateAssignedPicker.Location = new System.Drawing.Point(1286, 202);
            this.dateAssignedPicker.Margin = new System.Windows.Forms.Padding(6);
            this.dateAssignedPicker.Name = "dateAssignedPicker";
            this.dateAssignedPicker.Size = new System.Drawing.Size(396, 31);
            this.dateAssignedPicker.TabIndex = 16;
            // 
            // expectedCompletionDatePicker
            // 
            this.expectedCompletionDatePicker.Location = new System.Drawing.Point(1286, 285);
            this.expectedCompletionDatePicker.Margin = new System.Windows.Forms.Padding(6);
            this.expectedCompletionDatePicker.Name = "expectedCompletionDatePicker";
            this.expectedCompletionDatePicker.Size = new System.Drawing.Size(396, 31);
            this.expectedCompletionDatePicker.TabIndex = 17;
            // 
            // actualCompletitonDatePicker
            // 
            this.actualCompletitonDatePicker.Location = new System.Drawing.Point(1286, 383);
            this.actualCompletitonDatePicker.Margin = new System.Windows.Forms.Padding(6);
            this.actualCompletitonDatePicker.Name = "actualCompletitonDatePicker";
            this.actualCompletitonDatePicker.Size = new System.Drawing.Size(396, 31);
            this.actualCompletitonDatePicker.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(86, 469);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 25);
            this.label10.TabIndex = 19;
            this.label10.Text = "Status";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(86, 587);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(187, 25);
            this.label11.TabIndex = 20;
            this.label11.Text = "Status Description";
            // 
            // statusDescriptionTextBox
            // 
            this.statusDescriptionTextBox.Location = new System.Drawing.Point(91, 642);
            this.statusDescriptionTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.statusDescriptionTextBox.Multiline = true;
            this.statusDescriptionTextBox.Name = "statusDescriptionTextBox";
            this.statusDescriptionTextBox.Size = new System.Drawing.Size(280, 273);
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
            this.statusComboBox.Location = new System.Drawing.Point(232, 469);
            this.statusComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(280, 33);
            this.statusComboBox.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(419, 577);
            this.label13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(223, 25);
            this.label13.TabIndex = 25;
            this.label13.Text = "Available Action Items";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1018, 577);
            this.label14.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(200, 25);
            this.label14.TabIndex = 26;
            this.label14.Text = "Available Decisions";
            // 
            // associateActionItemButton
            // 
            this.associateActionItemButton.Location = new System.Drawing.Point(543, 982);
            this.associateActionItemButton.Margin = new System.Windows.Forms.Padding(6);
            this.associateActionItemButton.Name = "associateActionItemButton";
            this.associateActionItemButton.Size = new System.Drawing.Size(352, 44);
            this.associateActionItemButton.TabIndex = 30;
            this.associateActionItemButton.Text = "Associate Action Item";
            this.associateActionItemButton.UseVisualStyleBackColor = true;
            this.associateActionItemButton.Click += new System.EventHandler(this.AssociateActionItemButton_Click);
            // 
            // associateDecisionButton
            // 
            this.associateDecisionButton.Location = new System.Drawing.Point(1074, 982);
            this.associateDecisionButton.Margin = new System.Windows.Forms.Padding(6);
            this.associateDecisionButton.Name = "associateDecisionButton";
            this.associateDecisionButton.Size = new System.Drawing.Size(492, 44);
            this.associateDecisionButton.TabIndex = 31;
            this.associateDecisionButton.Text = "Associate Decision";
            this.associateDecisionButton.UseVisualStyleBackColor = true;
            this.associateDecisionButton.Click += new System.EventHandler(this.AssociateDecisionButton_Click);
            // 
            // unassociateActionItemButton
            // 
            this.unassociateActionItemButton.Location = new System.Drawing.Point(543, 1057);
            this.unassociateActionItemButton.Margin = new System.Windows.Forms.Padding(6);
            this.unassociateActionItemButton.Name = "unassociateActionItemButton";
            this.unassociateActionItemButton.Size = new System.Drawing.Size(352, 44);
            this.unassociateActionItemButton.TabIndex = 32;
            this.unassociateActionItemButton.Text = "Un-Associate Action Item";
            this.unassociateActionItemButton.UseVisualStyleBackColor = true;
            this.unassociateActionItemButton.Click += new System.EventHandler(this.UnassociateActionItemButton_Click);
            // 
            // unassociateDecisionButton
            // 
            this.unassociateDecisionButton.Location = new System.Drawing.Point(1074, 1057);
            this.unassociateDecisionButton.Margin = new System.Windows.Forms.Padding(6);
            this.unassociateDecisionButton.Name = "unassociateDecisionButton";
            this.unassociateDecisionButton.Size = new System.Drawing.Size(492, 44);
            this.unassociateDecisionButton.TabIndex = 33;
            this.unassociateDecisionButton.Text = "Un-Associate Decision";
            this.unassociateDecisionButton.UseVisualStyleBackColor = true;
            this.unassociateDecisionButton.Click += new System.EventHandler(this.UnassociateDecisionButton_Click);
            // 
            // actionItemsListBox
            // 
            this.actionItemsListBox.FormattingEnabled = true;
            this.actionItemsListBox.ItemHeight = 25;
            this.actionItemsListBox.Location = new System.Drawing.Point(424, 632);
            this.actionItemsListBox.Name = "actionItemsListBox";
            this.actionItemsListBox.Size = new System.Drawing.Size(253, 304);
            this.actionItemsListBox.TabIndex = 34;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(1642, 1015);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(150, 44);
            this.cancelButton.TabIndex = 76;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(1642, 1071);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(150, 44);
            this.saveButton.TabIndex = 75;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // currentActionItemsListBox
            // 
            this.currentActionItemsListBox.FormattingEnabled = true;
            this.currentActionItemsListBox.ItemHeight = 25;
            this.currentActionItemsListBox.Location = new System.Drawing.Point(720, 632);
            this.currentActionItemsListBox.Name = "currentActionItemsListBox";
            this.currentActionItemsListBox.Size = new System.Drawing.Size(253, 304);
            this.currentActionItemsListBox.TabIndex = 34;
            // 
            // decisionsListBox
            // 
            this.decisionsListBox.FormattingEnabled = true;
            this.decisionsListBox.ItemHeight = 25;
            this.decisionsListBox.Location = new System.Drawing.Point(1023, 632);
            this.decisionsListBox.Name = "decisionsListBox";
            this.decisionsListBox.Size = new System.Drawing.Size(253, 304);
            this.decisionsListBox.TabIndex = 34;
            // 
            // currentDecisionsListBox
            // 
            this.currentDecisionsListBox.FormattingEnabled = true;
            this.currentDecisionsListBox.ItemHeight = 25;
            this.currentDecisionsListBox.Location = new System.Drawing.Point(1350, 632);
            this.currentDecisionsListBox.Name = "currentDecisionsListBox";
            this.currentDecisionsListBox.Size = new System.Drawing.Size(253, 304);
            this.currentDecisionsListBox.TabIndex = 34;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(715, 577);
            this.label15.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(206, 25);
            this.label15.TabIndex = 25;
            this.label15.Text = "Current Action Items";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(1345, 577);
            this.label16.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(183, 25);
            this.label16.TabIndex = 26;
            this.label16.Text = "Current Decisions";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1012, 452);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(179, 25);
            this.label12.TabIndex = 13;
            this.label12.Text = "Last Update Date";
            // 
            // lastUpdatePicker
            // 
            this.lastUpdatePicker.Enabled = false;
            this.lastUpdatePicker.Location = new System.Drawing.Point(1290, 448);
            this.lastUpdatePicker.Margin = new System.Windows.Forms.Padding(6);
            this.lastUpdatePicker.Name = "lastUpdatePicker";
            this.lastUpdatePicker.Size = new System.Drawing.Size(396, 31);
            this.lastUpdatePicker.TabIndex = 18;
            // 
            // NewIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1804, 1131);
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
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "NewIssue";
            this.Text = "New Issue";
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