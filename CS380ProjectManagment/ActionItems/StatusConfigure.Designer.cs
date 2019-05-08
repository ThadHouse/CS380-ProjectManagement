namespace CS380ProjectManagment.ActionItems
{
    partial class StatusConfigure
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
            this.statiiListBox = new System.Windows.Forms.ListBox();
            this.toAddBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addAllowedButton = new System.Windows.Forms.Button();
            this.removeSelectedButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // statiiListBox
            // 
            this.statiiListBox.FormattingEnabled = true;
            this.statiiListBox.ItemHeight = 25;
            this.statiiListBox.Location = new System.Drawing.Point(310, 69);
            this.statiiListBox.Name = "statiiListBox";
            this.statiiListBox.Size = new System.Drawing.Size(218, 229);
            this.statiiListBox.TabIndex = 0;
            // 
            // toAddBox
            // 
            this.toAddBox.Location = new System.Drawing.Point(49, 106);
            this.toAddBox.Name = "toAddBox";
            this.toAddBox.Size = new System.Drawing.Size(225, 31);
            this.toAddBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "To Add";
            // 
            // addAllowedButton
            // 
            this.addAllowedButton.Location = new System.Drawing.Point(54, 164);
            this.addAllowedButton.Name = "addAllowedButton";
            this.addAllowedButton.Size = new System.Drawing.Size(220, 46);
            this.addAllowedButton.TabIndex = 3;
            this.addAllowedButton.Text = "Add Allowed Status";
            this.addAllowedButton.UseVisualStyleBackColor = true;
            this.addAllowedButton.Click += new System.EventHandler(this.AddAllowedButton_Click);
            // 
            // removeSelectedButton
            // 
            this.removeSelectedButton.Location = new System.Drawing.Point(310, 305);
            this.removeSelectedButton.Name = "removeSelectedButton";
            this.removeSelectedButton.Size = new System.Drawing.Size(218, 89);
            this.removeSelectedButton.TabIndex = 4;
            this.removeSelectedButton.Text = "Remove Selected Status";
            this.removeSelectedButton.UseVisualStyleBackColor = true;
            this.removeSelectedButton.Click += new System.EventHandler(this.RemoveSelectedButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(635, 327);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(6);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(150, 44);
            this.cancelButton.TabIndex = 78;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(635, 383);
            this.saveButton.Margin = new System.Windows.Forms.Padding(6);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(150, 44);
            this.saveButton.TabIndex = 77;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // StatusConfigure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.removeSelectedButton);
            this.Controls.Add(this.addAllowedButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toAddBox);
            this.Controls.Add(this.statiiListBox);
            this.Name = "StatusConfigure";
            this.Text = "StatusConfigure";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StatusConfigure_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox statiiListBox;
        private System.Windows.Forms.TextBox toAddBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addAllowedButton;
        private System.Windows.Forms.Button removeSelectedButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
    }
}