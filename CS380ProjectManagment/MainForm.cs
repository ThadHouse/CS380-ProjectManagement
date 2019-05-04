﻿using System;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void UpdateIssue_Click(object sender, EventArgs e)
        {
            NewIssue openForm = new NewIssue();
            openForm.Text = "Update Issue";
            
            openForm.Show();
        }

        private void CreateIssue_Click(object sender, EventArgs e)
        {
            NewIssue openForm = new NewIssue();
            openForm.Show();
        }

        private void CreateTaskButton_Click(object sender, EventArgs e)
        {
            TaskCreationForm creationForm = new TaskCreationForm();
            creationForm.Show();
        }

        private void UpdateTaskButton_Click(object sender, EventArgs e)
        {
            TaskUpdateForm creationForm = new TaskUpdateForm();
            creationForm.Show();
        }

        private void LoadGCButton_Click(object sender, EventArgs e)
        {
            LoadGC gc = new LoadGC();
            gc.Show();
        }

        private void DeleteGcButton_Click(object sender, EventArgs e)
        {
            DeleteGC gc = new DeleteGC();
            gc.Show();
        }
    }
}
