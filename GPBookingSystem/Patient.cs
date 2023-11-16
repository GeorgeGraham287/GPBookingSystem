using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GPBookingSystem
{
    public class Patient
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        private string hashedPassword;

        public List<Booking> Bookings { get; set; } = new List<Booking>();
        public void AddBooking(Doctor doctorBookingWith , DateTime timeOfBooking,string location)
        {
            
            Bookings.Add(new Booking(FirstName, LastName, DateTime.Now, location,doctorBookingWith.FullName));
            
        }

        public Patient(string firstName, string lastName, string email, string password)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            SetPassword(password);

            Bookings.Add(new Booking(firstName, lastName, DateTime.Now, "GP","Joe"));
            Bookings.Add(new Booking(firstName, lastName, DateTime.Now, "Hospital", "Joe"));
            Bookings.Add(new Booking(firstName, lastName, DateTime.Now, "K&C Hospital", "Joe"));

        }
        
        public void SetPassword(string password)
        {
            hashedPassword = HashPassword(password);
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public bool VerifyPassword(string password)
        {
            string hashedInput = HashPassword(password);
            return hashedInput == hashedPassword;
        }
    }

}
