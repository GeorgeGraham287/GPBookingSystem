using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPBookingSystem
{
    public static class ErrorMessages
    {
//#if DEBUG
        //SRP
        //=> error manager ? 
        // multiple places error messages might be shown => general
        public static string NameErrorMessage { get;  } = "Please Enter a Value";
        public static string PasswordErrorMessage { get; } = "Invalid Password must have a Minimum of eight characters, with at least one letter and one number";
        public static string EmailErrorMessage { get; } = "Invalid Email";
//#endif
    }
}
