using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPBookingSystem
{
    public partial class MainPage : UserControl
    {
        private BookingSystem _bookingSystem;
        public MainPage(BookingSystem booking)
        {
            _bookingSystem = booking;
            InitializeComponent();

            dataGridView1.DataSource = _bookingSystem.LoggedInPatient.Bookings;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = _bookingSystem.Doctors;
            
        }
    }
}
