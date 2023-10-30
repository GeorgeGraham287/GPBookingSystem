using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPBookingSystem
{
    public partial class LoginForm : UserControl
    {
        BookingSystem system;
        private Form1 parentForm;
        public LoginForm(Form1 form, BookingSystem booking)
        {
            system = booking;
            parentForm = form;
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if(system.AttemptLogin(EmailTextbox.Text, PasswordTextbox.Text))
            {
                parentForm.Controls.Clear();
                MainPage newPage = new MainPage(system);

                newPage.Dock = DockStyle.Fill;
                parentForm.Controls.Add(newPage);
            }
            else
            {
                errorProvider1.SetError(LoginButton, "Login Attempt Failed");
            }

            
        }

        //Register link => navitage to register page
        private void RegisterLink_Click(object sender, EventArgs e)
        {
            foreach (Control control in parentForm.Controls)
            {
                if (control is Panel)
                {
                    Panel foundPanel = (Panel)control;
                    RegistrationForm newPage = new RegistrationForm(parentForm, system);
                    newPage.Dock = DockStyle.Fill;
                    foundPanel.Controls.Clear();
                    foundPanel.Controls.Add(newPage);
                    break; // Found the panel, exit the loop
                }
            }
            
        }
    }
}
