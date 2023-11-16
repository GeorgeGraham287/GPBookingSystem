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
        public string Location { get; set; }
        public string DoctorName { get; set; }

        public Booking(string firstName, string lastName , DateTime bookingTime, string location,string doctorName)
        {
            FirstName = firstName;
            LastName = lastName;
            BookingTime = bookingTime;
            Location = location;
            DoctorName = doctorName;
        }

        
    }

    public class Doctor
    {
        public string FullName { get => DoctorsFirstName + " " + DoctorsLastName; }
        public string DoctorsFirstName { get; set; }
        public string DoctorsLastName { get; set; }

        public string DoctorsGender { get; set; }

        public string DoctorsWorkingDays { get; set; }

        public string DoctorsSpeciality { get; set; }

        public Doctor(string doctorsFirstName, string doctorsLastName, string doctorsGender, string doctorsWorkingDays, string doctorsSpeciality)
        {
            DoctorsFirstName = doctorsFirstName;
            DoctorsLastName = doctorsLastName;
            DoctorsGender = doctorsGender;
            DoctorsWorkingDays = doctorsWorkingDays;
            DoctorsSpeciality = doctorsSpeciality;
        }
    }
}
