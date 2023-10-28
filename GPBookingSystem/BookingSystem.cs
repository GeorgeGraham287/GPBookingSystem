using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPBookingSystem
{
    public class BookingSystem
    {
        private List<Patient> registeredPatients = new List<Patient>();
        public List<Patient> RegisteredPatients { get { return registeredPatients; } }


        //Attempt to login to the system
        public bool AttemptLogin(string email, string password)
        {
            for (int i=0; i<registeredPatients.Count; i++)
            {
                if (registeredPatients[i].Email == email && registeredPatients[i].VerifyPassword(password))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
