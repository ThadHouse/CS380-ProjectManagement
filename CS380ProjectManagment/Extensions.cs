using System;
using System.Windows.Forms;

namespace CS380ProjectManagment
{
    public static class Extensions
    {
        public static void AddSaveHandler(this Form form, Button saveButton)
        {
            form.KeyPreview = true;
            form.KeyDown += (o, e) =>
            {
                if (e.Control && e.KeyCode == Keys.S)
                {
                    saveButton.PerformClick();
                }
            };
        }

        public static void AddCloseHandler(this Form form, Button cancelButton)
        {
            form.KeyPreview = true;
            form.KeyDown += (o, e) =>
            {
                if (e.Control && e.KeyCode == Keys.D)
                {
                    cancelButton.PerformClick();
                }
            };
        }
    }
}
