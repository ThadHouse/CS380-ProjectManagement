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
            this.label4 = new System.Windows.Forms.Label();
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
            this.label11 = new System.Windows.Forms.Label();
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
            this.label1.Location = new System.Drawing.Point(86, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Task ID:";
            // 
            // idTextBox
            // 
            this.idTextBox.Enabled = false;
            this.idTextBox.Location = new System.Drawing.Point(234, 81);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(196, 31);
            this.idTextBox.TabIndex = 1;
            // 
            // milestoneCheckBox
            // 
            this.milestoneCheckBox.AutoSize = true;
            this.milestoneCheckBox.Location = new System.Drawing.Point(612, 85);
            this.milestoneCheckBox.Margin = new System.Windows.Forms.Padding(6);
            this.milestoneCheckBox.Name = "milestoneCheckBox";
            this.milestoneCheckBox.Size = new System.Drawing.Size(204, 29);
            this.milestoneCheckBox.TabIndex = 2;
            this.milestoneCheckBox.Text = "Set as Milestone";
            this.milestoneCheckBox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 142);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(234, 142);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(196, 31);
            this.nameTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 210);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Description:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(234, 210);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(582, 31);
            this.descriptionTextBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 283);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Resources:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(234, 285);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Available Resources";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(708, 283);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Current Resources";
            // 
            // availableResourcesListBox
            // 
            this.availableResourcesListBox.FormattingEnabled = true;
            this.availableResourcesListBox.ItemHeight = 25;
            this.availableResourcesListBox.Location = new System.Drawing.Point(234, 317);
            this.availableResourcesListBox.Margin = new System.Windows.Forms.Padding(6);
            this.availableResourcesListBox.Name = "availableResourcesListBox";
            this.availableResourcesListBox.Size = new System.Drawing.Size(236, 179);
            this.availableResourcesListBox.TabIndex = 10;
            // 
            // currentResourcesListBox
            // 
            this.currentResourcesListBox.FormattingEnabled = true;
            this.currentResourcesListBox.ItemHeight = 25;
            this.currentResourcesListBox.Location = new System.Drawing.Point(714, 317);
            this.currentResourcesListBox.Margin = new System.Windows.Forms.Padding(6);
            this.currentResourcesListBox.Name = "currentResourcesListBox";
            this.currentResourcesListBox.Size = new System.Drawing.Size(236, 179);
            this.currentResourcesListBox.TabIndex = 11;
            // 
            // addResourceButton
            // 
            this.addResourceButton.Location = new System.Drawing.Point(522, 344);
            this.addResourceButton.Margin = new System.Windows.Forms.Padding(6);
            this.addResourceButton.Name = "addResourceButton";
            this.addResourceButton.Size = new System.Drawing.Size(150, 44);
            this.addResourceButton.TabIndex = 12;
            this.addResourceButton.Text = "Add -->";
            this.addResourceButton.UseVisualStyleBackColor = true;
            this.addResourceButton.Click += new System.EventHandler(this.AddResourceButton_Click);
            // 
            // removeResourceButton
            // 
            this.removeResourceButton.Location = new System.Drawing.Point(522, 427);
            this.removeResourceButton.Margin = new System.Windows.Forms.Padding(6);
            this.removeResourceButton.Name = "removeResourceButton";
            this.removeResourceButton.Size = new System.Drawing.Size(150, 44);
            this.removeResourceButton.TabIndex = 13;
            this.removeResourceButton.Text = "<-- Remove";
            this.removeResourceButton.UseVisualStyleBackColor = true;
            this.removeResourceButton.Click += new System.EventHandler(this.RemoveResourceButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(86, 560);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(210, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Expected Start Date:";
            // 
            // expectedStartDatePicker
            // 
            this.expectedStartDatePicker.Location = new System.Drawing.Point(328, 544);
            this.expectedStartDatePicker.Margin = new System.Windows.Forms.Padding(6);
            this.expectedStartDatePicker.Name = "expectedStartDatePicker";
            this.expectedStartDatePicker.Size = new System.Drawing.Size(396, 31);
            this.expectedStartDatePicker.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(86, 623);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(203, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "Expected End Date:";
            // 
            // expectedEndDatePicker
            // 
            this.expectedEndDatePicker.Location = new System.Drawing.Point(328, 623);
            this.expectedEndDatePicker.Margin = new System.Windows.Forms.Padding(6);
            this.expectedEndDatePicker.Name = "expectedEndDatePicker";
            this.expectedEndDatePicker.Size = new System.Drawing.Size(396, 31);
            this.expectedEndDatePicker.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(86, 712);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(195, 25);
            this.label9.TabIndex = 18;
            this.label9.Text = "Expected Duration:";
            // 
            // expectedDuration
            // 
            this.expectedDuration.Location = new System.Drawing.Point(328, 698);
            this.expectedDuration.Margin = new System.Windows.Forms.Padding(6);
            this.expectedDuration.Name = "expectedDuration";
            this.expectedDuration.Size = new System.Drawing.Size(146, 31);
            this.expectedDuration.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(486, 712);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 25);
            this.label10.TabIndex = 20;
            this.label10.Text = "in days";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(92, 794);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(203, 25);
            this.label11.TabIndex = 21;
            this.label11.Text = "Predecessor Tasks:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(328, 792);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(134, 25);
            this.label12.TabIndex = 22;
            this.label12.Text = "List of Tasks";
            // 
            // allTasksListBox
            // 
            this.allTasksListBox.FormattingEnabled = true;
            this.allTasksListBox.ItemHeight = 25;
            this.allTasksListBox.Location = new System.Drawing.Point(334, 825);
            this.allTasksListBox.Margin = new System.Windows.Forms.Padding(6);
            this.allTasksListBox.Name = "allTasksListBox";
            this.allTasksListBox.Size = new System.Drawing.Size(236, 179);
            this.allTasksListBox.TabIndex = 23;
            // 
            // addPredecessorButton
            // 
            this.addPredecessorButton.Location = new System.Drawing.Point(612, 848);
            this.addPredecessorButton.Margin = new System.Windows.Forms.Padding(6);
            this.addPredecessorButton.Name = "addPredecessorButton";
            this.addPredecessorButton.Size = new System.Drawing.Size(150, 44);
            this.addPredecessorButton.TabIndex = 24;
            this.addPredecessorButton.Text = "Add -->";
            this.addPredecessorButton.UseVisualStyleBackColor = true;
            this.addPredecessorButton.Click += new System.EventHandler(this.AddPredecessorButton_Click);
            // 
            // removePredecessorButton
            // 
            this.removePredecessorButton.Location = new System.Drawing.Point(612, 938);
            this.removePredecessorButton.Margin = new System.Windows.Forms.Padding(6);
            this.removePredecessorButton.Name = "removePredecessorButton";
            this.removePredecessorButton.Size = new System.Drawing.Size(150, 44);
            this.removePredecessorButton.TabIndex = 25;
            this.removePredecessorButton.Text = "<-- Remove";
            this.removePredecessorButton.UseVisualStyleBackColor = true;
            this.removePredecessorButton.Click += new System.EventHandler(this.RemovePredecessorButton_Click);
            // 
            // predecessorListBox
            // 
            this.predecessorListBox.FormattingEnabled = true;
            this.predecessorListBox.ItemHeight = 25;
            this.predecessorListBox.Location = new System.Drawing.Point(798, 825);
            this.predecessorListBox.Margin = new System.Windows.Forms.Padding(6);
            this.predecessorListBox.Name = "predecessorListBox";
            this.predecessorListBox.Size = new System.Drawing.Size(236, 179);
            this.predecessorListBox.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(792, 792);
            this.label13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(197, 25);
            this.label13.TabIndex = 27;
            this.label13.Text = "Predecessor Tasks";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(678, 1060);
            this.label14.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(145, 25);
            this.label14.TabIndex = 34;
            this.label14.Text = "Finish to Start";
            // 
            // finishToStartListBox
            // 
            this.finishToStartListBox.FormattingEnabled = true;
            this.finishToStartListBox.ItemHeight = 25;
            this.finishToStartListBox.Location = new System.Drawing.Point(684, 1085);
            this.finishToStartListBox.Margin = new System.Windows.Forms.Padding(6);
            this.finishToStartListBox.Name = "finishToStartListBox";
            this.finishToStartListBox.Size = new System.Drawing.Size(164, 179);
            this.finishToStartListBox.TabIndex = 33;
            // 
            // removeFinishToStartButton
            // 
            this.removeFinishToStartButton.Location = new System.Drawing.Point(684, 1335);
            this.removeFinishToStartButton.Margin = new System.Windows.Forms.Padding(6);
            this.removeFinishToStartButton.Name = "removeFinishToStartButton";
            this.removeFinishToStartButton.Size = new System.Drawing.Size(168, 44);
            this.removeFinishToStartButton.TabIndex = 32;
            this.removeFinishToStartButton.Text = "<-- Remove";
            this.removeFinishToStartButton.UseVisualStyleBackColor = true;
            this.removeFinishToStartButton.Click += new System.EventHandler(this.SuccessorRemoveButton_Click);
            // 
            // addFinishToStartButton
            // 
            this.addFinishToStartButton.Location = new System.Drawing.Point(684, 1279);
            this.addFinishToStartButton.Margin = new System.Windows.Forms.Padding(6);
            this.addFinishToStartButton.Name = "addFinishToStartButton";
            this.addFinishToStartButton.Size = new System.Drawing.Size(168, 44);
            this.addFinishToStartButton.TabIndex = 31;
            this.addFinishToStartButton.Text = "Add -->";
            this.addFinishToStartButton.UseVisualStyleBackColor = true;
            this.addFinishToStartButton.Click += new System.EventHandler(this.SuccessorAddButton_Click);
            // 
            // allTasksListBox2
            // 
            this.allTasksListBox2.FormattingEnabled = true;
            this.allTasksListBox2.ItemHeight = 25;
            this.allTasksListBox2.Location = new System.Drawing.Point(334, 1090);
            this.allTasksListBox2.Margin = new System.Windows.Forms.Padding(6);
            this.allTasksListBox2.Name = "allTasksListBox2";
            this.allTasksListBox2.Size = new System.Drawing.Size(236, 179);
            this.allTasksListBox2.TabIndex = 30;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(328, 1058);
            this.label15.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(134, 25);
            this.label15.TabIndex = 29;
            this.label15.Text = "List of Tasks";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(92, 1060);
            this.label16.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(183, 25);
            this.label16.TabIndex = 28;
            this.label16.Text = "Successor Tasks:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(864, 1060);
            this.label17.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(132, 25);
            this.label17.TabIndex = 38;
            this.label17.Text = "Start to Start";
            // 
            // startToStartListBox
            // 
            this.startToStartListBox.FormattingEnabled = true;
            this.startToStartListBox.ItemHeight = 25;
            this.startToStartListBox.Location = new System.Drawing.Point(870, 1085);
            this.startToStartListBox.Margin = new System.Windows.Forms.Padding(6);
            this.startToStartListBox.Name = "startToStartListBox";
            this.startToStartListBox.Size = new System.Drawing.Size(164, 179);
            this.startToStartListBox.TabIndex = 37;
            // 
            // removeStartToStartButton
            // 
            this.removeStartToStartButton.Location = new System.Drawing.Point(870, 1335);
            this.removeStartToStartButton.Margin = new System.Windows.Forms.Padding(6);
            this.removeStartToStartButton.Name = "removeStartToStartButton";
            this.removeStartToStartButton.Size = new System.Drawing.Size(168, 44);
            this.removeStartToStartButton.TabIndex = 36;
            this.removeStartToStartButton.Text = "<-- Remove";
            this.removeStartToStartButton.UseVisualStyleBackColor = true;
            this.removeStartToStartButton.Click += new System.EventHandler(this.SuccessorRemoveButton_Click);
            // 
            // addStartToStartButton
            // 
            this.addStartToStartButton.Location = new System.Drawing.Point(870, 1279);
            this.addStartToStartButton.Margin = new System.Windows.Forms.Padding(6);
            this.addStartToStartButton.Name = "addStartToStartButton";
            this.addStartToStartButton.Size = new System.Drawing.Size(168, 44);
            this.addStartToStartButton.TabIndex = 35;
            this.addStartToStartButton.Text = "Add -->";
            this.addStartToStartButton.UseVisualStyleBackColor = true;
            this.addStartToStartButton.Click += new System.EventHandler(this.SuccessorAddButton_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(1044, 1060);
            this.label18.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(158, 25);
            this.label18.TabIndex = 42;
            this.label18.Text = "Finish to Finish";
            // 
            // finishToFinishListBox
            // 
            this.finishToFinishListBox.FormattingEnabled = true;
            this.finishToFinishListBox.ItemHeight = 25;
            this.finishToFinishListBox.Location = new System.Drawing.Point(1050, 1085);
            this.finishToFinishListBox.Margin = new System.Windows.Forms.Padding(6);
            this.finishToFinishListBox.Name = "finishToFinishListBox";
            this.finishToFinishListBox.Size = new System.Drawing.Size(164, 179);
            this.finishToFinishListBox.TabIndex = 41;
            // 
            // removeFinishToFinishButton
            // 
            this.removeFinishToFinishButton.Location = new System.Drawing.Point(1050, 1335);
            this.removeFinishToFinishButton.Margin = new System.Windows.Forms.Padding(6);
            this.removeFinishToFinishButton.Name = "removeFinishToFinishButton";
            this.removeFinishToFinishButton.Size = new System.Drawing.Size(168, 44);
            this.removeFinishToFinishButton.TabIndex = 40;
            this.removeFinishToFinishButton.Text = "<-- Remove";
            this.removeFinishToFinishButton.UseVisualStyleBackColor = true;
            this.removeFinishToFinishButton.Click += new System.EventHandler(this.SuccessorRemoveButton_Click);
            // 
            // addFinishToFinishButton
            // 
            this.addFinishToFinishButton.Location = new System.Drawing.Point(1050, 1279);
            this.addFinishToFinishButton.Margin = new System.Windows.Forms.Padding(6);
            this.addFinishToFinishButton.Name = "addFinishToFinishButton";
            this.addFinishToFinishButton.Size = new System.Drawing.Size(168, 44);
            this.addFinishToFinishButton.TabIndex = 39;
            this.addFinishToFinishButton.Text = "Add -->";
            this.addFinishToFinishButton.UseVisualStyleBackColor = true;
            this.addFinishToFinishButton.Click += new System.EventHandler(this.SuccessorAddButton_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(1224, 1060);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(145, 25);
            this.label19.TabIndex = 46;
            this.label19.Text = "Start to Finish";
            // 
            // startToFinishListBox
            // 
            this.startToFinishListBox.FormattingEnabled = true;
            this.startToFinishListBox.ItemHeight = 25;
            this.startToFinishListBox.Location = new System.Drawing.Point(1230, 1085);
            this.startToFinishListBox.Name = "startToFinishListBox";
            this.startToFinishListBox.Size = new System.Drawing.Size(164, 179);
            this.startToFinishListBox.TabIndex = 45;
            // 
            // removeStartToFinishButton
            // 
            this.removeStartToFinishButton.Location = new System.Drawing.Point(1230, 1335);
            this.removeStartToFinishButton.Name = "removeStartToFinishButton";
            this.removeStartToFinishButton.Size = new System.Drawing.Size(168, 44);
            this.removeStartToFinishButton.TabIndex = 44;
            this.removeStartToFinishButton.Text = "<-- Remove";
            this.removeStartToFinishButton.UseVisualStyleBackColor = true;
            this.removeStartToFinishButton.Click += new System.EventHandler(this.SuccessorRemoveButton_Click);
            // 
            // addStartToFinishButton
            // 
            this.addStartToFinishButton.Location = new System.Drawing.Point(1230, 1279);
            this.addStartToFinishButton.Name = "addStartToFinishButton";
            this.addStartToFinishButton.Size = new System.Drawing.Size(168, 44);
            this.addStartToFinishButton.TabIndex = 43;
            this.addStartToFinishButton.Text = "Add -->";
            this.addStartToFinishButton.UseVisualStyleBackColor = true;
            this.addStartToFinishButton.Click += new System.EventHandler(this.SuccessorAddButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(1426, 1356);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(150, 44);
            this.saveButton.TabIndex = 73;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.Save_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(1426, 1300);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(150, 44);
            this.cancelButton.TabIndex = 74;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // TaskCreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1645, 1432);
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
            this.Controls.Add(this.label11);
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
            this.Controls.Add(this.label4);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.milestoneCheckBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "TaskCreationForm";
            this.Text = "Task Creation Form";
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
        private System.Windows.Forms.Label label4;
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
        private System.Windows.Forms.Label label11;
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