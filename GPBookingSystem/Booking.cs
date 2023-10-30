using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPBookingSystem
{
    public class Booking
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BookingTime { get; set; }

        public Booking(string firstName, string lastName , DateTime bookingTime)
        {
            FirstName = firstName;
            LastName = lastName;
            BookingTime = bookingTime;
        }
    }
}
