using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPBookingSystem
{
    public partial class RegistrationForm : UserControl
    {
        private Regex passwordValidationRegex = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d\w\W]{8,}$");

        private string nameErrorMessage = ErrorMessages.NameErrorMessage;
        private string passwordErrorMessage = ErrorMessages.PasswordErrorMessage;
        private string emailErrorMessage = ErrorMessages.EmailErrorMessage;

        Form1 parentForm;
        BookingSystem booking;

        public RegistrationForm(Form1 form, BookingSystem system)
        {
            InitializeComponent();
            booking = system;
            parentForm = form;
        }

        private bool SetError(Control control, string errorMessage)
        {
            errorProvider1.SetError(control, errorMessage);
            return false;
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            bool valid = true;
            valid &= ValidateNotEmpty(FirstNameTextbox, nameErrorMessage);
            valid &= ValidateNotEmpty(SecondNameTextbox, nameErrorMessage);
            valid &= ValidatePassword(PasswordTextbox.Text);
            valid &= ValidateEmail(EmailTextbox.Text);

            if (valid)
            {
                // Before registering, check if the email is already used by another patient.
                if (!EmailAlreadyExists(EmailTextbox.Text))
                {
                    RegisterPatient(FirstNameTextbox.Text, SecondNameTextbox.Text, EmailTextbox.Text, PasswordTextbox.Text);
                    DisplaySuccessMessage();
                }
                else
                {
                    SetError(EmailTextbox, "Email already in use. Please use a different one.");
                }
            }
        }

        // Checks if the email provided is already associated with a registered patient.
        private bool EmailAlreadyExists(string email)
        {
            return booking.RegisteredPatients.Exists(p => p.Email.Equals(email, StringComparison.OrdinalIgnoreCase));
        }

        private bool ValidateNotEmpty(TextBox textbox, string errorMessage)
        {
            if (String.IsNullOrWhiteSpace(textbox.Text))
            {
                return SetError(textbox, errorMessage);
            }
            else
            {
                errorProvider1.SetError(textbox, "");
                return true;
            }
        }

        private bool ValidatePassword(string password)
        {
            if (!passwordValidationRegex.Match(password).Success)
            {
                return SetError(PasswordTextbox, passwordErrorMessage);
            }
            else
            {
                errorProvider1.SetError(PasswordTextbox, "");
                return true;
            }
        }

        private bool ValidateEmail(string email)
        {
            if (String.IsNullOrWhiteSpace(email))
            {
                return SetError(EmailTextbox, emailErrorMessage);
            }
            try
            {
                var mailAddress = new System.Net.Mail.MailAddress(email);
                errorProvider1.SetError(EmailTextbox, "");
                return true;
            }
            catch (FormatException)
            {
                return SetError(EmailTextbox, emailErrorMessage);
            }
        }

        private void RegisterPatient(string firstName, string secondName, string email, string password)
        {
            var patient = new Patient(firstName, secondName, email, password);
            booking.RegisteredPatients.Add(patient);
        }

        private void DisplaySuccessMessage()
        {
            var successLabel = new Label
            {
                Text = "Registerd!",
                ForeColor = Color.Green,

            };
            successLabel.Location = new Point(RegisterButton.Location.X - successLabel.Width - 10, RegisterButton.Location.Y);
            successLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Controls.Add(successLabel);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            foreach (Control control in parentForm.Controls)
            {
                if (control is Panel)
                {
                    Panel foundPanel = (Panel)control;
                    LoginForm newPage = new LoginForm(parentForm, booking);
                    newPage.Dock = DockStyle.Fill;
                    foundPanel.Controls.Clear();
                    foundPanel.Controls.Add(newPage);
                    break; // Found the panel, exit the loop
                }
            }
        }
    }
}

