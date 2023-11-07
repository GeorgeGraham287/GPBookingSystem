using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPBookingSystem
{
    public static class ErrorMessages
    {
        public static string NameErrorMessage { get; } = "Please enter a value.";
        public static string PasswordErrorMessage { get; } = "Password must have a minimum of 8 characters, with at least one letter and one number.";
        public static string ConfirmPasswordErrorMessage { get; } = "Passwords do not match.";
        public static string EmailErrorMessage { get; } = "Please enter a valid email address.";
    }
}
