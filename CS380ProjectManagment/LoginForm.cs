using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS380ProjectManagment
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        #region InputEvents
        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = !showPasswordCheckBox.Checked;
        }

        private async void LoginButton_Click(object sender, EventArgs e)
        {
            DisableInputs();
            await HandleLogin();
            EnableInputs();
        }

        private async void PasswordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                DisableInputs();
                await HandleLogin();
                EnableInputs();
            }
        }
        #endregion

        private void EnableInputs()
        {
            usernameTextBox.Enabled = true;
            passwordTextBox.Enabled = true;
            loginButton.Enabled = true;
            showPasswordCheckBox.Enabled = true;
        }

        private void DisableInputs()
        {
            usernameTextBox.Enabled = false;
            passwordTextBox.Enabled = false;
            loginButton.Enabled = false;
            showPasswordCheckBox.Enabled = false;
        }

        private async Task HandleLogin()
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            await Task.Delay(4000);
            Form1 form = new Form1();
            form.Show();

            // TODO: Finish this
        }
    }
}
