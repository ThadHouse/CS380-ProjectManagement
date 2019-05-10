namespace CS380ProjectManagment
{
    partial class TaskCreationForm
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
            this.milestoneCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.availableResourcesListBox = new System.Windows.Forms.ListBox();
            this.currentResourcesListBox = new System.Windows.Forms.ListBox();
            this.addResourceButton = new System.Windows.Forms.Button();
            this.removeResourceButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.expectedStartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.expectedEndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.expectedDuration = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.allTasksListBox = new System.Windows.Forms.ListBox();
            this.addPredecessorButton = new System.Windows.Forms.Button();
            this.removePredecessorButton = new System.Windows.Forms.Button();
            this.predecessorListBox = new System.Windows.Forms.ListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.finishToStartListBox = new System.Windows.Forms.ListBox();
            this.removeFinishToStartButton = new System.Windows.Forms.Button();
            this.addFinishToStartButton = new System.Windows.Forms.Button();
            this.allTasksListBox2 = new System.Windows.Forms.ListBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.startToStartListBox = new System.Windows.Forms.ListBox();
            this.removeStartToStartButton = new System.Windows.Forms.Button();
            this.addStartToStartButton = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.finishToFinishListBox = new System.Windows.Forms.ListBox();
            this.removeFinishToFinishButton = new System.Windows.Forms.Button();
            this.addFinishToFinishButton = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.startToFinishListBox = new System.Windows.Forms.ListBox();
            this.removeStartToFinishButton = new System.Windows.Forms.Button();
            this.addStartToFinishButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.expectedDuration)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Task ID:";
            // 
            // idTextBox
            // 
            this.idTextBox.Enabled = false;
            this.idTextBox.Location = new System.Drawing.Point(85, 13);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 1;
            // 
            // milestoneCheckBox
            // 
            this.milestoneCheckBox.AutoSize = true;
            this.milestoneCheckBox.Location = new System.Drawing.Point(274, 15);
            this.milestoneCheckBox.Name = "milestoneCheckBox";
            this.milestoneCheckBox.Size = new System.Drawing.Size(104, 17);
            this.milestoneCheckBox.TabIndex = 2;
            this.milestoneCheckBox.Text = "Set as Milestone";
            this.milestoneCheckBox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(85, 45);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Description:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(85, 80);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(293, 20);
            this.descriptionTextBox.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(415, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Available Resources";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(652, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Current Resources";
            // 
            // availableResourcesListBox
            // 
            this.availableResourcesListBox.FormattingEnabled = true;
            this.availableResourcesListBox.Location = new System.Drawing.Point(415, 36);
            this.availableResourcesListBox.Name = "availableResourcesListBox";
            this.availableResourcesListBox.Size = new System.Drawing.Size(120, 95);
            this.availableResourcesListBox.TabIndex = 10;
            // 
            // currentResourcesListBox
            // 
            this.currentResourcesListBox.FormattingEnabled = true;
            this.currentResourcesListBox.Location = new System.Drawing.Point(655, 36);
            this.currentResourcesListBox.Name = "currentResourcesListBox";
            this.currentResourcesListBox.Size = new System.Drawing.Size(120, 95);
            this.currentResourcesListBox.TabIndex = 11;
            // 
            // addResourceButton
            // 
            this.addResourceButton.Location = new System.Drawing.Point(559, 50);
            this.addResourceButton.Name = "addResourceButton";
            this.addResourceButton.Size = new System.Drawing.Size(75, 23);
            this.addResourceButton.TabIndex = 12;
            this.addResourceButton.Text = "Add -->";
            this.addResourceButton.UseVisualStyleBackColor = true;
            this.addResourceButton.Click += new System.EventHandler(this.AddResourceButton_Click);
            // 
            // removeResourceButton
            // 
            this.removeResourceButton.Location = new System.Drawing.Point(559, 93);
            this.removeResourceButton.Name = "removeResourceButton";
            this.removeResourceButton.Size = new System.Drawing.Size(75, 23);
            this.removeResourceButton.TabIndex = 13;
            this.removeResourceButton.Text = "<-- Remove";
            this.removeResourceButton.UseVisualStyleBackColor = true;
            this.removeResourceButton.Click += new System.EventHandler(this.RemoveResourceButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Expected Start Date:";
            // 
            // expectedStartDatePicker
            // 
            this.expectedStartDatePicker.Location = new System.Drawing.Point(146, 144);
            this.expectedStartDatePicker.Name = "expectedStartDatePicker";
            this.expectedStartDatePicker.Size = new System.Drawing.Size(200, 20);
            this.expectedStartDatePicker.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Expected End Date:";
            // 
            // expectedEndDatePicker
            // 
            this.expectedEndDatePicker.Location = new System.Drawing.Point(146, 185);
            this.expectedEndDatePicker.Name = "expectedEndDatePicker";
            this.expectedEndDatePicker.Size = new System.Drawing.Size(200, 20);
            this.expectedEndDatePicker.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 231);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Expected Duration:";
            // 
            // expectedDuration
            // 
            this.expectedDuration.Location = new System.Drawing.Point(146, 224);
            this.expectedDuration.Name = "expectedDuration";
            this.expectedDuration.Size = new System.Drawing.Size(73, 20);
            this.expectedDuration.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(225, 231);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "in days";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(412, 159);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "List of Tasks";
            // 
            // allTasksListBox
            // 
            this.allTasksListBox.FormattingEnabled = true;
            this.allTasksListBox.Location = new System.Drawing.Point(415, 176);
            this.allTasksListBox.Name = "allTasksListBox";
            this.allTasksListBox.Size = new System.Drawing.Size(120, 95);
            this.allTasksListBox.TabIndex = 23;
            // 
            // addPredecessorButton
            // 
            this.addPredecessorButton.Location = new System.Drawing.Point(554, 188);
            this.addPredecessorButton.Name = "addPredecessorButton";
            this.addPredecessorButton.Size = new System.Drawing.Size(75, 23);
            this.addPredecessorButton.TabIndex = 24;
            this.addPredecessorButton.Text = "Add -->";
            this.addPredecessorButton.UseVisualStyleBackColor = true;
            this.addPredecessorButton.Click += new System.EventHandler(this.AddPredecessorButton_Click);
            // 
            // removePredecessorButton
            // 
            this.removePredecessorButton.Location = new System.Drawing.Point(554, 217);
            this.removePredecessorButton.Name = "removePredecessorButton";
            this.removePredecessorButton.Size = new System.Drawing.Size(75, 23);
            this.removePredecessorButton.TabIndex = 25;
            this.removePredecessorButton.Text = "<-- Remove";
            this.removePredecessorButton.UseVisualStyleBackColor = true;
            this.removePredecessorButton.Click += new System.EventHandler(this.RemovePredecessorButton_Click);
            // 
            // predecessorListBox
            // 
            this.predecessorListBox.FormattingEnabled = true;
            this.predecessorListBox.Location = new System.Drawing.Point(647, 176);
            this.predecessorListBox.Name = "predecessorListBox";
            this.predecessorListBox.Size = new System.Drawing.Size(120, 95);
            this.predecessorListBox.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(644, 159);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Predecessor Tasks";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(318, 309);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 13);
            this.label14.TabIndex = 34;
            this.label14.Text = "Finish to Start";
            // 
            // finishToStartListBox
            // 
            this.finishToStartListBox.FormattingEnabled = true;
            this.finishToStartListBox.Location = new System.Drawing.Point(321, 322);
            this.finishToStartListBox.Name = "finishToStartListBox";
            this.finishToStartListBox.Size = new System.Drawing.Size(84, 95);
            this.finishToStartListBox.TabIndex = 33;
            // 
            // removeFinishToStartButton
            // 
            this.removeFinishToStartButton.Location = new System.Drawing.Point(321, 452);
            this.removeFinishToStartButton.Name = "removeFinishToStartButton";
            this.removeFinishToStartButton.Size = new System.Drawing.Size(84, 23);
            this.removeFinishToStartButton.TabIndex = 32;
            this.removeFinishToStartButton.Text = "<-- Remove";
            this.removeFinishToStartButton.UseVisualStyleBackColor = true;
            this.removeFinishToStartButton.Click += new System.EventHandler(this.SuccessorRemoveButton_Click);
            // 
            // addFinishToStartButton
            // 
            this.addFinishToStartButton.Location = new System.Drawing.Point(321, 423);
            this.addFinishToStartButton.Name = "addFinishToStartButton";
            this.addFinishToStartButton.Size = new System.Drawing.Size(84, 23);
            this.addFinishToStartButton.TabIndex = 31;
            this.addFinishToStartButton.Text = "Add -->";
            this.addFinishToStartButton.UseVisualStyleBackColor = true;
            this.addFinishToStartButton.Click += new System.EventHandler(this.SuccessorAddButton_Click);
            // 
            // allTasksListBox2
            // 
            this.allTasksListBox2.FormattingEnabled = true;
            this.allTasksListBox2.Location = new System.Drawing.Point(146, 325);
            this.allTasksListBox2.Name = "allTasksListBox2";
            this.allTasksListBox2.Size = new System.Drawing.Size(120, 95);
            this.allTasksListBox2.TabIndex = 30;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(143, 308);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "List of Tasks";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(25, 309);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(92, 13);
            this.label16.TabIndex = 28;
            this.label16.Text = "Successor Tasks:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(411, 309);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(66, 13);
            this.label17.TabIndex = 38;
            this.label17.Text = "Start to Start";
            // 
            // startToStartListBox
            // 
            this.startToStartListBox.FormattingEnabled = true;
            this.startToStartListBox.Location = new System.Drawing.Point(414, 322);
            this.startToStartListBox.Name = "startToStartListBox";
            this.startToStartListBox.Size = new System.Drawing.Size(84, 95);
            this.startToStartListBox.TabIndex = 37;
            // 
            // removeStartToStartButton
            // 
            this.removeStartToStartButton.Location = new System.Drawing.Point(414, 452);
            this.removeStartToStartButton.Name = "removeStartToStartButton";
            this.removeStartToStartButton.Size = new System.Drawing.Size(84, 23);
            this.removeStartToStartButton.TabIndex = 36;
            this.removeStartToStartButton.Text = "<-- Remove";
            this.removeStartToStartButton.UseVisualStyleBackColor = true;
            this.removeStartToStartButton.Click += new System.EventHandler(this.SuccessorRemoveButton_Click);
            // 
            // addStartToStartButton
            // 
            this.addStartToStartButton.Location = new System.Drawing.Point(414, 423);
            this.addStartToStartButton.Name = "addStartToStartButton";
            this.addStartToStartButton.Size = new System.Drawing.Size(84, 23);
            this.addStartToStartButton.TabIndex = 35;
            this.addStartToStartButton.Text = "Add -->";
            this.addStartToStartButton.UseVisualStyleBackColor = true;
            this.addStartToStartButton.Click += new System.EventHandler(this.SuccessorAddButton_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(501, 309);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(76, 13);
            this.label18.TabIndex = 42;
            this.label18.Text = "Finish to Finish";
            // 
            // finishToFinishListBox
            // 
            this.finishToFinishListBox.FormattingEnabled = true;
            this.finishToFinishListBox.Location = new System.Drawing.Point(504, 322);
            this.finishToFinishListBox.Name = "finishToFinishListBox";
            this.finishToFinishListBox.Size = new System.Drawing.Size(84, 95);
            this.finishToFinishListBox.TabIndex = 41;
            // 
            // removeFinishToFinishButton
            // 
            this.removeFinishToFinishButton.Location = new System.Drawing.Point(504, 452);
            this.removeFinishToFinishButton.Name = "removeFinishToFinishButton";
            this.removeFinishToFinishButton.Size = new System.Drawing.Size(84, 23);
            this.removeFinishToFinishButton.TabIndex = 40;
            this.removeFinishToFinishButton.Text = "<-- Remove";
            this.removeFinishToFinishButton.UseVisualStyleBackColor = true;
            this.removeFinishToFinishButton.Click += new System.EventHandler(this.SuccessorRemoveButton_Click);
            // 
            // addFinishToFinishButton
            // 
            this.addFinishToFinishButton.Location = new System.Drawing.Point(504, 423);
            this.addFinishToFinishButton.Name = "addFinishToFinishButton";
            this.addFinishToFinishButton.Size = new System.Drawing.Size(84, 23);
            this.addFinishToFinishButton.TabIndex = 39;
            this.addFinishToFinishButton.Text = "Add -->";
            this.addFinishToFinishButton.UseVisualStyleBackColor = true;
            this.addFinishToFinishButton.Click += new System.EventHandler(this.SuccessorAddButton_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(591, 309);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(71, 13);
            this.label19.TabIndex = 46;
            this.label19.Text = "Start to Finish";
            // 
            // startToFinishListBox
            // 
            this.startToFinishListBox.FormattingEnabled = true;
            this.startToFinishListBox.Location = new System.Drawing.Point(594, 322);
            this.startToFinishListBox.Margin = new System.Windows.Forms.Padding(2);
            this.startToFinishListBox.Name = "startToFinishListBox";
            this.startToFinishListBox.Size = new System.Drawing.Size(84, 95);
            this.startToFinishListBox.TabIndex = 45;
            // 
            // removeStartToFinishButton
            // 
            this.removeStartToFinishButton.Location = new System.Drawing.Point(594, 452);
            this.removeStartToFinishButton.Margin = new System.Windows.Forms.Padding(2);
            this.removeStartToFinishButton.Name = "removeStartToFinishButton";
            this.removeStartToFinishButton.Size = new System.Drawing.Size(84, 23);
            this.removeStartToFinishButton.TabIndex = 44;
            this.removeStartToFinishButton.Text = "<-- Remove";
            this.removeStartToFinishButton.UseVisualStyleBackColor = true;
            this.removeStartToFinishButton.Click += new System.EventHandler(this.SuccessorRemoveButton_Click);
            // 
            // addStartToFinishButton
            // 
            this.addStartToFinishButton.Location = new System.Drawing.Point(594, 423);
            this.addStartToFinishButton.Margin = new System.Windows.Forms.Padding(2);
            this.addStartToFinishButton.Name = "addStartToFinishButton";
            this.addStartToFinishButton.Size = new System.Drawing.Size(84, 23);
            this.addStartToFinishButton.TabIndex = 43;
            this.addStartToFinishButton.Text = "Add -->";
            this.addStartToFinishButton.UseVisualStyleBackColor = true;
            this.addStartToFinishButton.Click += new System.EventHandler(this.SuccessorAddButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(692, 463);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 73;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.Save_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(692, 434);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 74;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // TaskCreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 498);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.startToFinishListBox);
            this.Controls.Add(this.removeStartToFinishButton);
            this.Controls.Add(this.addStartToFinishButton);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.finishToFinishListBox);
            this.Controls.Add(this.removeFinishToFinishButton);
            this.Controls.Add(this.addFinishToFinishButton);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.startToStartListBox);
            this.Controls.Add(this.removeStartToStartButton);
            this.Controls.Add(this.addStartToStartButton);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.finishToStartListBox);
            this.Controls.Add(this.removeFinishToStartButton);
            this.Controls.Add(this.addFinishToStartButton);
            this.Controls.Add(this.allTasksListBox2);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.predecessorListBox);
            this.Controls.Add(this.removePredecessorButton);
            this.Controls.Add(this.addPredecessorButton);
            this.Controls.Add(this.allTasksListBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.expectedDuration);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.expectedEndDatePicker);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.expectedStartDatePicker);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.removeResourceButton);
            this.Controls.Add(this.addResourceButton);
            this.Controls.Add(this.currentResourcesListBox);
            this.Controls.Add(this.availableResourcesListBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.milestoneCheckBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.label1);
            this.Name = "TaskCreationForm";
            this.Text = "Create New Task";
            ((System.ComponentModel.ISupportInitialize)(this.expectedDuration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.CheckBox milestoneCheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox availableResourcesListBox;
        private System.Windows.Forms.ListBox currentResourcesListBox;
        private System.Windows.Forms.Button addResourceButton;
        private System.Windows.Forms.Button removeResourceButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker expectedStartDatePicker;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker expectedEndDatePicker;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown expectedDuration;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox allTasksListBox;
        private System.Windows.Forms.Button addPredecessorButton;
        private System.Windows.Forms.Button removePredecessorButton;
        private System.Windows.Forms.ListBox predecessorListBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ListBox finishToStartListBox;
        private System.Windows.Forms.Button removeFinishToStartButton;
        private System.Windows.Forms.Button addFinishToStartButton;
        private System.Windows.Forms.ListBox allTasksListBox2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ListBox startToStartListBox;
        private System.Windows.Forms.Button removeStartToStartButton;
        private System.Windows.Forms.Button addStartToStartButton;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ListBox finishToFinishListBox;
        private System.Windows.Forms.Button removeFinishToFinishButton;
        private System.Windows.Forms.Button addFinishToFinishButton;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ListBox startToFinishListBox;
        private System.Windows.Forms.Button removeStartToFinishButton;
        private System.Windows.Forms.Button addStartToFinishButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
    }
}