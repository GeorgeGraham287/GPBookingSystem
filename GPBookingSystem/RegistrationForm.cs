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

        private bool SetError(Control control, string errorMessage)
        {
            errorProvider1.SetError(control, errorMessage);
            return false;
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            bool valid = true;
            
            string firstName = FirstNameTextbox.Text;
            string secondName = SecondNameTextbox.Text;
            string email = EmailTextbox.Text;
            string password = PasswordTextbox.Text;

            //* refactor ?  
            //Simple null check for names
            if (FirstNameTextbox.Text == "")
            {
                valid = SetError(FirstNameTextbox, nameErrorMessage);
            }
            else
            {
                errorProvider1.SetError(FirstNameTextbox, "");
            }
            if (SecondNameTextbox.Text == "")
            {
                valid = SetError(SecondNameTextbox, nameErrorMessage);
            }
            else
            {
                errorProvider1.SetError(SecondNameTextbox, "");
            }


            //Password Validation
            if (!passwordValidationRegex.Match(PasswordTextbox.Text).Success)
            {
                valid = SetError(PasswordTextbox, passwordErrorMessage);
            }
            else
            {
                errorProvider1.SetError(PasswordTextbox, "");
            }

            //Email Validation
            try
            {
                string emailString = EmailTextbox.Text;
                if(emailString != "")
                {
                    MailAddress mailAddress = new MailAddress(emailString);
                    errorProvider1.SetError(EmailTextbox, "");
                }
                else
                {
                    valid = SetError(EmailTextbox, emailErrorMessage);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Email is not valid.");
                valid = SetError(EmailTextbox, emailErrorMessage);
            }

            Console.WriteLine("hello?>");
            //Debug.WriteLine(valid);
            //Actually do registration
            if (valid)
            {
                //Debug.WriteLine("User Registered");
                Patient p = new Patient(firstName, secondName, email, password);
                //-> setter method
                booking.RegisteredPatients.Add(p);
                Label l = new Label();
                l.Text = "Success";
                l.BackColor = Color.Chartreuse;
                //RegisterButton.Location.X-l.Width-10 , RegisterButton.Location.Y
                l.Location = new Point(RegisterButton.Location.X - l.Width - 10, RegisterButton.Location.Y);
                this.Controls.Add(l);
                
            }
            

        }
        Form1 parentForm;
        BookingSystem booking;
        public RegistrationForm(Form1 form,BookingSystem system)
        {
            booking = system;
            parentForm = form;
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            foreach (Control control in parentForm.Controls)
            {
                if (control is Panel)
                {
                    Panel foundPanel = (Panel)control;
                    LoginForm newPage = new LoginForm(parentForm,booking);
                    newPage.Dock = DockStyle.Fill;
                    foundPanel.Controls.Clear();
                    foundPanel.Controls.Add(newPage);
                    break; // Found the panel, exit the loop
                }
            }
        }
    }
}
