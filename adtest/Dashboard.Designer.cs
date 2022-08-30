namespace adtest
{
    partial class Dashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputGroupBox = new System.Windows.Forms.GroupBox();
            this.propertyTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.mailTextBox = new System.Windows.Forms.TextBox();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.propertyLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.mailLabel = new System.Windows.Forms.Label();
            this.urlLabel = new System.Windows.Forms.Label();
            this.outputGroupBox = new System.Windows.Forms.GroupBox();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.signInButton = new System.Windows.Forms.Button();
            this.signInProgressBar = new System.Windows.Forms.ProgressBar();
            this.inputGroupBox.SuspendLayout();
            this.outputGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputGroupBox
            // 
            this.inputGroupBox.Controls.Add(this.propertyTextBox);
            this.inputGroupBox.Controls.Add(this.passwordTextBox);
            this.inputGroupBox.Controls.Add(this.mailTextBox);
            this.inputGroupBox.Controls.Add(this.urlTextBox);
            this.inputGroupBox.Controls.Add(this.propertyLabel);
            this.inputGroupBox.Controls.Add(this.passwordLabel);
            this.inputGroupBox.Controls.Add(this.mailLabel);
            this.inputGroupBox.Controls.Add(this.urlLabel);
            this.inputGroupBox.Location = new System.Drawing.Point(12, 12);
            this.inputGroupBox.Name = "inputGroupBox";
            this.inputGroupBox.Size = new System.Drawing.Size(365, 165);
            this.inputGroupBox.TabIndex = 0;
            this.inputGroupBox.TabStop = false;
            this.inputGroupBox.Text = "Datos de entrada:";
            // 
            // propertyTextBox
            // 
            this.propertyTextBox.Location = new System.Drawing.Point(104, 120);
            this.propertyTextBox.Name = "propertyTextBox";
            this.propertyTextBox.Size = new System.Drawing.Size(233, 23);
            this.propertyTextBox.TabIndex = 4;
            this.propertyTextBox.Text = "(userPrincipalName=[mail])";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(104, 91);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '•';
            this.passwordTextBox.Size = new System.Drawing.Size(233, 23);
            this.passwordTextBox.TabIndex = 3;
            // 
            // mailTextBox
            // 
            this.mailTextBox.Location = new System.Drawing.Point(104, 62);
            this.mailTextBox.Name = "mailTextBox";
            this.mailTextBox.Size = new System.Drawing.Size(233, 23);
            this.mailTextBox.TabIndex = 2;
            // 
            // urlTextBox
            // 
            this.urlTextBox.Location = new System.Drawing.Point(104, 33);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(233, 23);
            this.urlTextBox.TabIndex = 1;
            this.urlTextBox.Text = "LDAP://sub.domain.com:389";
            // 
            // propertyLabel
            // 
            this.propertyLabel.AutoSize = true;
            this.propertyLabel.Location = new System.Drawing.Point(34, 123);
            this.propertyLabel.Name = "propertyLabel";
            this.propertyLabel.Size = new System.Drawing.Size(64, 15);
            this.propertyLabel.TabIndex = 1;
            this.propertyLabel.Text = "Propiedad:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(28, 94);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(70, 15);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Contraseña:";
            // 
            // mailLabel
            // 
            this.mailLabel.AutoSize = true;
            this.mailLabel.Location = new System.Drawing.Point(52, 65);
            this.mailLabel.Name = "mailLabel";
            this.mailLabel.Size = new System.Drawing.Size(46, 15);
            this.mailLabel.TabIndex = 1;
            this.mailLabel.Text = "Correo:";
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Location = new System.Drawing.Point(73, 36);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(25, 15);
            this.urlLabel.TabIndex = 0;
            this.urlLabel.Text = "Url:";
            // 
            // outputGroupBox
            // 
            this.outputGroupBox.Controls.Add(this.outputTextBox);
            this.outputGroupBox.Location = new System.Drawing.Point(12, 212);
            this.outputGroupBox.Name = "outputGroupBox";
            this.outputGroupBox.Size = new System.Drawing.Size(365, 100);
            this.outputGroupBox.TabIndex = 1;
            this.outputGroupBox.TabStop = false;
            this.outputGroupBox.Text = "Resultado:";
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(6, 22);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.outputTextBox.Size = new System.Drawing.Size(353, 72);
            this.outputTextBox.TabIndex = 0;
            // 
            // signInButton
            // 
            this.signInButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signInButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.signInButton.Location = new System.Drawing.Point(12, 183);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(365, 23);
            this.signInButton.TabIndex = 2;
            this.signInButton.Text = "INICIAR SESIÓN";
            this.signInButton.UseVisualStyleBackColor = true;
            this.signInButton.Click += new System.EventHandler(this.signInButton_Click);
            // 
            // signInProgressBar
            // 
            this.signInProgressBar.Location = new System.Drawing.Point(12, 318);
            this.signInProgressBar.Name = "signInProgressBar";
            this.signInProgressBar.Size = new System.Drawing.Size(365, 10);
            this.signInProgressBar.TabIndex = 3;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 336);
            this.Controls.Add(this.signInProgressBar);
            this.Controls.Add(this.signInButton);
            this.Controls.Add(this.outputGroupBox);
            this.Controls.Add(this.inputGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Dashboard";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Active Directory - Test";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.inputGroupBox.ResumeLayout(false);
            this.inputGroupBox.PerformLayout();
            this.outputGroupBox.ResumeLayout(false);
            this.outputGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox inputGroupBox;
        private TextBox propertyTextBox;
        private TextBox passwordTextBox;
        private TextBox mailTextBox;
        private TextBox urlTextBox;
        private Label propertyLabel;
        private Label passwordLabel;
        private Label mailLabel;
        private Label urlLabel;
        private GroupBox outputGroupBox;
        private TextBox outputTextBox;
        private Button signInButton;
        private ProgressBar signInProgressBar;
    }
}