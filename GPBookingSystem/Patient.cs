﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GPBookingSystem
{
    public class Patient
    {

        public string FirstName { get; set; } = "undefined";
        public string LastName { get; set; } = "undefined";
        public string Email { get; set; } = "undefined";
        public string Password { get; set; }


        public List<Booking> Bookings { get; set; }


        public Patient(string firstName, string lastName , string email, string password)
        {
            //Validate password
            //Password must not be null. among other things

            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;

            Bookings = new List<Booking>() { new Booking(FirstName, LastName, new DateTime(1,1,1,1,1,1)), new Booking(FirstName, LastName, DateTime.Now), new Booking(FirstName, LastName, DateTime.Now) };

        }
        public bool VerifyPassword(string password)
        {
            if(password == Password)
            {
                return true;
            }
            return false;
        }
    }
}
