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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            comboBox1.DataSource = _bookingSystem.Doctors;
            comboBox1.DisplayMember = "FullName";
            comboBox1.Refresh();


            locationBox.DataSource = new List<string> { "GP", "Hopsital" };
            locationBox.Refresh();
            locationBox.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = _bookingSystem.Doctors;

        }

        private void RescheduleButton_Click(object sender, EventArgs e)
        {
            
            
            DateTime newDateTime = BookingDatePicker.Value.Date.Add(BookingTimePicker.Value.TimeOfDay);
            _bookingSystem.LoggedInPatient.Bookings[dataGridView1.CurrentCell.RowIndex].BookingTime = newDateTime;
            
            dataGridView1.DataSource = _bookingSystem.LoggedInPatient.Bookings;
            dataGridView1.Refresh();
            
        }

        private void AddNewBookingButton_Click(object sender, EventArgs e)
        {
            if(dataGridView1.DataSource == _bookingSystem.LoggedInPatient.Bookings)
            {
                
                DateTime newDateTime = BookingDatePicker.Value.Date.Add(BookingTimePicker.Value.TimeOfDay);
                _bookingSystem.LoggedInPatient.AddBooking((Doctor)comboBox1.SelectedItem, newDateTime,locationBox.SelectedItem.ToString());

                dataGridView1.DataSource = _bookingSystem.Doctors;
                dataGridView1.Refresh();
                dataGridView1.DataSource = _bookingSystem.LoggedInPatient.Bookings;
                dataGridView1.Refresh();
            }
            
        }

        private void ViewBookingsButton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _bookingSystem.LoggedInPatient.Bookings;
            dataGridView1.Refresh();
        }

        private void ViewDoctorsButton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _bookingSystem.Doctors;
            dataGridView1.Refresh();
        }
    }
}
