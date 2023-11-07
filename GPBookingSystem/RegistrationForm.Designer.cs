namespace GPBookingSystem
{
    partial class RegistrationForm
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
            PasswordLabel = new Label();
            PasswordTextbox = new TextBox();
            EmailLabel = new Label();
            SecondNameLabel = new Label();
            FirstNameLabel = new Label();
            RegisterButton = new Button();
            EmailTextbox = new TextBox();
            SecondNameTextbox = new TextBox();
            FirstNameTextbox = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            BackButton = new Button();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // PasswordLabel
            // 
            PasswordLabel.Anchor = AnchorStyles.None;
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            PasswordLabel.Location = new Point(15, 146);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(97, 25);
            PasswordLabel.TabIndex = 17;
            PasswordLabel.Text = "Password";
            // 
            // PasswordTextbox
            // 
            PasswordTextbox.Anchor = AnchorStyles.None;
            PasswordTextbox.Location = new Point(150, 147);
            PasswordTextbox.Multiline = true;
            PasswordTextbox.Name = "PasswordTextbox";
            PasswordTextbox.Size = new Size(233, 27);
            PasswordTextbox.TabIndex = 16;
            // 
            // EmailLabel
            // 
            EmailLabel.Anchor = AnchorStyles.None;
            EmailLabel.AutoSize = true;
            EmailLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            EmailLabel.Location = new Point(15, 104);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(59, 25);
            EmailLabel.TabIndex = 15;
            EmailLabel.Text = "Email";
            // 
            // SecondNameLabel
            // 
            SecondNameLabel.Anchor = AnchorStyles.None;
            SecondNameLabel.AutoSize = true;
            SecondNameLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            SecondNameLabel.Location = new Point(15, 62);
            SecondNameLabel.Name = "SecondNameLabel";
            SecondNameLabel.Size = new Size(104, 25);
            SecondNameLabel.TabIndex = 14;
            SecondNameLabel.Text = "Last Name";
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.Anchor = AnchorStyles.None;
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            FirstNameLabel.Location = new Point(15, 15);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(107, 25);
            FirstNameLabel.TabIndex = 13;
            FirstNameLabel.Text = "First Name";
            // 
            // RegisterButton
            // 
            RegisterButton.Anchor = AnchorStyles.None;
            RegisterButton.BackColor = Color.FromArgb(128, 128, 255);
            RegisterButton.FlatStyle = FlatStyle.Flat;
            RegisterButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            RegisterButton.ForeColor = SystemColors.ButtonHighlight;
            RegisterButton.Location = new Point(289, 217);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(94, 29);
            RegisterButton.TabIndex = 12;
            RegisterButton.Text = "Register";
            RegisterButton.UseVisualStyleBackColor = false;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // EmailTextbox
            // 
            EmailTextbox.Anchor = AnchorStyles.None;
            EmailTextbox.Location = new Point(150, 105);
            EmailTextbox.Multiline = true;
            EmailTextbox.Name = "EmailTextbox";
            EmailTextbox.Size = new Size(233, 27);
            EmailTextbox.TabIndex = 11;
            // 
            // SecondNameTextbox
            // 
            SecondNameTextbox.Anchor = AnchorStyles.None;
            SecondNameTextbox.Location = new Point(150, 63);
            SecondNameTextbox.Multiline = true;
            SecondNameTextbox.Name = "SecondNameTextbox";
            SecondNameTextbox.Size = new Size(233, 27);
            SecondNameTextbox.TabIndex = 10;
            // 
            // FirstNameTextbox
            // 
            FirstNameTextbox.Anchor = AnchorStyles.None;
            FirstNameTextbox.Location = new Point(150, 16);
            FirstNameTextbox.Multiline = true;
            FirstNameTextbox.Name = "FirstNameTextbox";
            FirstNameTextbox.Size = new Size(233, 27);
            FirstNameTextbox.TabIndex = 9;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // BackButton
            // 
            BackButton.Anchor = AnchorStyles.None;
            BackButton.BackColor = Color.FromArgb(0, 0, 64);
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BackButton.ForeColor = SystemColors.ButtonHighlight;
            BackButton.Location = new Point(15, 217);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(94, 29);
            BackButton.TabIndex = 18;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(BackButton);
            Controls.Add(PasswordLabel);
            Controls.Add(PasswordTextbox);
            Controls.Add(EmailLabel);
            Controls.Add(SecondNameLabel);
            Controls.Add(FirstNameLabel);
            Controls.Add(RegisterButton);
            Controls.Add(EmailTextbox);
            Controls.Add(SecondNameTextbox);
            Controls.Add(FirstNameTextbox);
            Name = "RegistrationForm";
            Size = new Size(402, 272);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PasswordLabel;
        private TextBox PasswordTextbox;
        private Label EmailLabel;
        private Label SecondNameLabel;
        private Label FirstNameLabel;
        private Button RegisterButton;
        private TextBox EmailTextbox;
        private TextBox SecondNameTextbox;
        private TextBox FirstNameTextbox;
        private ErrorProvider errorProvider1;
        private Button BackButton;
    }
}
