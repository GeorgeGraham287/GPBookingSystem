using System.Diagnostics;
using System.Net.Mail;
using System.Security.Policy;
using System.Text.RegularExpressions;

namespace GPBookingSystem
{
    public partial class Form1 : Form
    {
        private Regex passwordValidationRegex = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d\w\W]{8,}$");
        private List<Patient> registeredPatients = new List<Patient>();
        public Form1()
        {
            InitializeComponent();

            //Initial page = Login Form
            Control newPage = new LoginForm(this,new BookingSystem());
            newPage.Width = panel1.Width;
            newPage.Height = panel1.Height;
            panel1.Controls.Add(newPage);

        }

        

        
    }
}