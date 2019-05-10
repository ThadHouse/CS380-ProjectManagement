namespace CS380ProjectManagment
{
    partial class BasePanel<T>
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.createButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.valuesListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(50, 40);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(871, 50);
            this.createButton.TabIndex = 0;
            this.createButton.Text = "button1";
            this.createButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(502, 622);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(419, 75);
            this.deleteButton.TabIndex = 0;
            this.deleteButton.Text = "button1";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(502, 488);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(419, 71);
            this.updateButton.TabIndex = 0;
            this.updateButton.Text = "button1";
            this.updateButton.UseVisualStyleBackColor = true;
            // 
            // valuesListBox
            // 
            this.valuesListBox.FormattingEnabled = true;
            this.valuesListBox.ItemHeight = 25;
            this.valuesListBox.Location = new System.Drawing.Point(50, 156);
            this.valuesListBox.Name = "valuesListBox";
            this.valuesListBox.Size = new System.Drawing.Size(400, 604);
            this.valuesListBox.TabIndex = 1;
            // 
            // BasePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.valuesListBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.createButton);
            this.Name = "BasePanel";
            this.Size = new System.Drawing.Size(951, 808);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.ListBox valuesListBox;
    }
}
