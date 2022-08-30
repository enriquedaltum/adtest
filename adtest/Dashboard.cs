using System.DirectoryServices;

namespace adtest
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            mailTextBox.Select();
        }

        private async void signInButton_Click(object sender, EventArgs e)
        {
            try
            {
                outputTextBox.Clear();
                EnableControls(false);
                InProgress();
                Application.DoEvents();

                if (AreValidFields())
                {
                    await Task.Run(() =>
                    {
                        DirectoryEntry entry = new DirectoryEntry(urlTextBox.Text, mailTextBox.Text, passwordTextBox.Text);
                        entry.AuthenticationType = AuthenticationTypes.Secure;
                        DirectorySearcher search = new DirectorySearcher(entry);

                        if (!string.IsNullOrEmpty(propertyTextBox.Text))
                        {
                            search.Filter = propertyTextBox.Text.Replace("[mail]", mailTextBox.Text);
                        }

                        SearchResult? results = search.FindOne();

                        if (results is not null)
                        {
                            outputTextBox.Text += "Usuario encontrado.\n";
                            outputTextBox.Text += $"{results}\n";
                        }
                        else
                        {
                            outputTextBox.Text += "Usuario no encontrado.\n";
                        }
                    });
                }
            }
            catch (Exception ex)
            {
                outputTextBox.Text += $"ERROR | {ex.Message} | {ex.StackTrace}";
            }
            finally
            {
                outputTextBox.ScrollToCaret();
                EnableControls();
                InProgress(false);
            }
        }

        private void EnableControls(bool enable = true)
        {
            foreach (Control c in Controls)
            {
                c.Enabled = enable;
            }
        }

        private void InProgress(bool inProgress = true)
        {
            signInProgressBar.Style = inProgress ? ProgressBarStyle.Marquee : ProgressBarStyle.Blocks;
        }

        private bool AreValidFields()
        {
            try
            {
                if(string.IsNullOrEmpty(urlTextBox.Text))
                {
                    MessageBox.Show("Debes ingresar la Url.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    urlTextBox.Select();
                    return false;
                }

                if (string.IsNullOrEmpty(mailTextBox.Text))
                {
                    MessageBox.Show("Debes ingresar el correo.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mailTextBox.Select();
                    return false;
                }

                if (string.IsNullOrEmpty(passwordTextBox.Text))
                {
                    MessageBox.Show("Debes ingresar la contraseña.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    passwordTextBox.Select();
                    return false;
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}