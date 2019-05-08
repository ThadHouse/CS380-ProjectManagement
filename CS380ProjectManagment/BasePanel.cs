﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS380ProjectManagment
{
    public partial class BasePanel<T> : UserControl where T : Base
    {

        public BasePanel(string name, Func<List<T>> getItemList, Func<Form> createForm = null, Func<string, Form> updateForm = null)
        {
            InitializeComponent();
            var list = getItemList?.Invoke();
            if (list != null)
            {
                valuesListBox.Items.Clear();

                foreach (string nm in list.Select(x => x.Name))
                {
                    valuesListBox.Items.Add(nm);
                }
            }
            string nameWithoutS = name.Substring(0, name.Length - 1);
            if (name[name.Length - 1] != 's')
            {
                nameWithoutS = name;
            }
            this.createButton.Text = $"Create New {nameWithoutS}";
            this.UpdateButton.Text = $"Update Selected {nameWithoutS}";
            this.DeleteButton.Text = $"Delete Selected {nameWithoutS}";

            this.createButton.Click += (o, e) =>
            {
                if (createForm == null)
                {
                    ProjectManagement.NotImplementedMessageBox();
                    return;
                }
                Form newForm = createForm();
                newForm.FormClosed += (o2, e2) =>
                {
                    var items = getItemList?.Invoke();
                    if (items == null) return;
                    valuesListBox.Items.Clear();
                    
                    foreach (string nm in items.Select(x => x.Name))
                    {
                        valuesListBox.Items.Add(nm);
                    }
                };
                newForm.Show();
            };

            this.UpdateButton.Click += (o, e) =>
            {
                if (updateForm == null)
                {
                    ProjectManagement.NotImplementedMessageBox();
                    return;
                }
                Form newForm = updateForm(this.valuesListBox.SelectedItem as string);
                if (newForm == null)
                {
                    MessageBox.Show("Item does not exist");
                    return;
                }
                newForm.FormClosed += (o2, e2) =>
                {
                    var items = getItemList?.Invoke();
                    if (items == null) return;
                    valuesListBox.Items.Clear();

                    foreach (string nm in items.Select(x => x.Name))
                    {
                        valuesListBox.Items.Add(nm);
                    }
                };
                newForm.Show();
            };

            this.DeleteButton.Click += (o, e) =>
            {
                var items = getItemList?.Invoke();
                if (items == null) return;
                var res = MessageBox.Show("Are you sure you would like to delete?", "Delete Confirmation", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    var item = items.Where(x => x.Name == valuesListBox.SelectedItem as string).FirstOrDefault();
                    if (item != null)
                    {
                        items.Remove(item);
                        Database.Save();
                        valuesListBox.Items.Clear();

                        foreach (string nm in items.Select(x => x.Name))
                        {
                            valuesListBox.Items.Add(nm);
                        }
                    } else
                    {
                        MessageBox.Show("Hmm, weird error item not found in DB");
                    }
                }
            };
        }
    }
}
