namespace GPBookingSystem
{
    partial class LoginForm
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
            components = new System.ComponentModel.Container();
            SecondNameLabel = new Label();
            FirstNameLabel = new Label();
            LoginButton = new Button();
            PasswordTextbox = new TextBox();
            EmailTextbox = new TextBox();
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            RegisterLink = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // SecondNameLabel
            // 
            SecondNameLabel.Anchor = AnchorStyles.None;
            SecondNameLabel.AutoSize = true;
            SecondNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SecondNameLabel.Location = new Point(31, 103);
            SecondNameLabel.Name = "SecondNameLabel";
            SecondNameLabel.Size = new Size(101, 28);
            SecondNameLabel.TabIndex = 23;
            SecondNameLabel.Text = "Password";
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.Anchor = AnchorStyles.None;
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            FirstNameLabel.Location = new Point(31, 20);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(64, 28);
            FirstNameLabel.TabIndex = 22;
            FirstNameLabel.Text = "Email";
            // 
            // LoginButton
            // 
            LoginButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            LoginButton.BackColor = Color.FromArgb(128, 128, 255);
            LoginButton.FlatStyle = FlatStyle.Flat;
            LoginButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LoginButton.ForeColor = SystemColors.ButtonHighlight;
            LoginButton.Location = new Point(155, 236);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(94, 29);
            LoginButton.TabIndex = 21;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // PasswordTextbox
            // 
            PasswordTextbox.Anchor = AnchorStyles.None;
            PasswordTextbox.Location = new Point(31, 134);
            PasswordTextbox.Multiline = true;
            PasswordTextbox.Name = "PasswordTextbox";
            PasswordTextbox.PasswordChar = '#';
            PasswordTextbox.Size = new Size(233, 42);
            PasswordTextbox.TabIndex = 19;
            // 
            // EmailTextbox
            // 
            EmailTextbox.Anchor = AnchorStyles.None;
            EmailTextbox.Location = new Point(31, 51);
            EmailTextbox.Multiline = true;
            EmailTextbox.Name = "EmailTextbox";
            EmailTextbox.Size = new Size(233, 39);
            EmailTextbox.TabIndex = 18;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 24;
            label1.Text = "Login";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // RegisterLink
            // 
            RegisterLink.Anchor = AnchorStyles.Bottom;
            RegisterLink.AutoSize = true;
            RegisterLink.Cursor = Cursors.Hand;
            RegisterLink.ForeColor = Color.Blue;
            RegisterLink.Location = new Point(63, 191);
            RegisterLink.Name = "RegisterLink";
            RegisterLink.Size = new Size(161, 20);
            RegisterLink.TabIndex = 25;
            RegisterLink.Text = "Register as new Patient";
            RegisterLink.Click += RegisterLink_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(RegisterLink);
            Controls.Add(label1);
            Controls.Add(SecondNameLabel);
            Controls.Add(FirstNameLabel);
            Controls.Add(LoginButton);
            Controls.Add(PasswordTextbox);
            Controls.Add(EmailTextbox);
            Name = "LoginForm";
            Size = new Size(288, 285);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label SecondNameLabel;
        private Label FirstNameLabel;
        private Button LoginButton;
        private TextBox PasswordTextbox;
        private TextBox EmailTextbox;
        private Label label1;
        private ErrorProvider errorProvider1;
        private Label RegisterLink;
    }
}
