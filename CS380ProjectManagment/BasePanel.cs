using System;
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
        public Button CreateButton { get; }
        public Button UpdateButton { get; }
        public Button DeleteButton { get; }

        private Func<Form> createForm;
        private Func<List<T>> getItemList;

        public void CreateButtonHandler(object sender, EventArgs e)
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
        }

        public BasePanel(string name, Func<List<T>> getItemList, Func<Form> createForm = null, Func<string, Form> updateForm = null)
        {
            InitializeComponent();
            CreateButton = createButton;
            UpdateButton = updateButton;
            DeleteButton = deleteButton;
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
            this.updateButton.Text = $"Update Selected {nameWithoutS}";
            this.deleteButton.Text = $"Delete Selected {nameWithoutS}";

            this.createForm = createForm;
            this.getItemList = getItemList;

            this.createButton.Click += CreateButtonHandler;

            this.updateButton.Click += (o, e) =>
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

            this.deleteButton.Click += (o, e) =>
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
