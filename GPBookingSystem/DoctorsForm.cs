using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPBookingSystem
{
    
      public class DoctorsForm
        {

            public List<Doctor> allDoctors { get; set; }

            public DoctorsForm()
            {


                allDoctors = new List<Doctor>()
                {
                      new Doctor("Tom", "Redwood", "Male", "Monday, Tuesday", "Family Medicine"),
                      new Doctor("Sheley", "Strawus", "Female", "Wednesday, Thursday", "Neurology"),
                      new Doctor("Biba", "De sooza", "Male", "Friday, Saturday", "Internal Medicine")
                };
            }

      }
    
}
