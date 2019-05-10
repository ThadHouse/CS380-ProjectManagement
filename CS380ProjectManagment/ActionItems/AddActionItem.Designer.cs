namespace CS380ProjectManagment.ActionItems
{
    partial class AddActionItem
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
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.removeResourceButton = new System.Windows.Forms.Button();
            this.addResourceButton = new System.Windows.Forms.Button();
            this.availableResourcesListBox = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.expectedCompletion = new System.Windows.Forms.DateTimePicker();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ConfigureStatusButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.statusDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.CurrentResourceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(99, 46);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(167, 20);
            this.idTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Task ID:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(99, 75);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(167, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // removeResourceButton
            // 
            this.removeResourceButton.Location = new System.Drawing.Point(243, 222);
            this.removeResourceButton.Name = "removeResourceButton";
            this.removeResourceButton.Size = new System.Drawing.Size(75, 23);
            this.removeResourceButton.TabIndex = 22;
            this.removeResourceButton.Text = "<-- Remove";
            this.removeResourceButton.UseVisualStyleBackColor = true;
            this.removeResourceButton.Click += new System.EventHandler(this.RemoveResourceButton_Click);
            // 
            // addResourceButton
            // 
            this.addResourceButton.Location = new System.Drawing.Point(243, 179);
            this.addResourceButton.Name = "addResourceButton";
            this.addResourceButton.Size = new System.Drawing.Size(75, 23);
            this.addResourceButton.TabIndex = 21;
            this.addResourceButton.Text = "Add -->";
            this.addResourceButton.UseVisualStyleBackColor = true;
            this.addResourceButton.Click += new System.EventHandler(this.AddResourceButton_Click);
            // 
            // availableResourcesListBox
            // 
            this.availableResourcesListBox.FormattingEnabled = true;
            this.availableResourcesListBox.Location = new System.Drawing.Point(99, 165);
            this.availableResourcesListBox.Name = "availableResourcesListBox";
            this.availableResourcesListBox.Size = new System.Drawing.Size(120, 95);
            this.availableResourcesListBox.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(336, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Current Resource";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(99, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Available Resources";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Resources:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(99, 109);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(293, 20);
            this.descriptionTextBox.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Description:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Expected Completion Date:";
            // 
            // expectedCompletion
            // 
            this.expectedCompletion.Location = new System.Drawing.Point(154, 289);
            this.expectedCompletion.Name = "expectedCompletion";
            this.expectedCompletion.Size = new System.Drawing.Size(200, 20);
            this.expectedCompletion.TabIndex = 15;
            // 
            // statusComboBox
            // 
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Items.AddRange(new object[] {
            "Open",
            "Closed",
            "In Progress",
            "Hold",
            "Complete"});
            this.statusComboBox.Location = new System.Drawing.Point(99, 346);
            this.statusComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(120, 21);
            this.statusComboBox.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 347);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Status";
            // 
            // ConfigureStatusButton
            // 
            this.ConfigureStatusButton.Location = new System.Drawing.Point(243, 336);
            this.ConfigureStatusButton.Margin = new System.Windows.Forms.Padding(2);
            this.ConfigureStatusButton.Name = "ConfigureStatusButton";
            this.ConfigureStatusButton.Size = new System.Drawing.Size(147, 24);
            this.ConfigureStatusButton.TabIndex = 25;
            this.ConfigureStatusButton.Text = "Configure Allowed Status\'s";
            this.ConfigureStatusButton.UseVisualStyleBackColor = true;
            this.ConfigureStatusButton.Click += new System.EventHandler(this.ConfigureStatusButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 407);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Status Description";
            // 
            // statusDescriptionTextBox
            // 
            this.statusDescriptionTextBox.Location = new System.Drawing.Point(130, 404);
            this.statusDescriptionTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.statusDescriptionTextBox.Name = "statusDescriptionTextBox";
            this.statusDescriptionTextBox.Size = new System.Drawing.Size(214, 20);
            this.statusDescriptionTextBox.TabIndex = 27;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(428, 444);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 76;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(428, 473);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 75;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CurrentResourceLabel
            // 
            this.CurrentResourceLabel.AutoSize = true;
            this.CurrentResourceLabel.Location = new System.Drawing.Point(346, 188);
            this.CurrentResourceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CurrentResourceLabel.Name = "CurrentResourceLabel";
            this.CurrentResourceLabel.Size = new System.Drawing.Size(33, 13);
            this.CurrentResourceLabel.TabIndex = 77;
            this.CurrentResourceLabel.Text = "None";
            // 
            // AddActionItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 502);
            this.Controls.Add(this.CurrentResourceLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.statusDescriptionTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ConfigureStatusButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(this.removeResourceButton);
            this.Controls.Add(this.addResourceButton);
            this.Controls.Add(this.availableResourcesListBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.expectedCompletion);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddActionItem";
            this.Text = "Create New Action Item";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button removeResourceButton;
        private System.Windows.Forms.Button addResourceButton;
        private System.Windows.Forms.ListBox availableResourcesListBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker expectedCompletion;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button ConfigureStatusButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox statusDescriptionTextBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label CurrentResourceLabel;
    }
}