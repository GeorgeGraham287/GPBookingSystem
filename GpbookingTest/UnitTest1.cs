using GPBookingSystem;

namespace GpbookingTest
{
    public class UnitTest1
    {
        //test for invalid password
        [Fact]
        public void ValidatePassword_InvalidPassword_ReturnsFalse()
        {
            Form1 f = new Form1();
            RegistrationForm form = new RegistrationForm(f, new BookingSystem());

            bool result = form.ValidatePassword("password");

            Assert.False(result);
        }

        //test for valid password
        [Fact]
        public void ValidatePassword_ValidPassword_ReturnsTrue()
        {
            Form1 f = new Form1();
            RegistrationForm form = new RegistrationForm(f, new BookingSystem());

            bool result = form.ValidatePassword("Password1");

            Assert.True(result);
        }
        // test for invalid Email
        [Fact]
        public void ValidateEmail_InvalidEmail_ReturnsFalse()
        {
            Form1 f = new Form1();
            RegistrationForm form = new RegistrationForm(f,new BookingSystem());


            bool result = form.ValidateEmail("hello");

            Assert.False(result);
        }
        //test for valid Email
        [Fact]
        public void ValidateEmail_ValidEmail_ReturnsTrue()
        {
            Form1 f = new Form1();
            RegistrationForm form = new RegistrationForm(f,new BookingSystem());

            bool result = form.ValidateEmail("GG287@canterbury.ac.uk");

            Assert.True(result);
        }



        // Test for a successful login
        [Fact]
        public void AttemptLogin_ValidCredentials_ReturnsTrue()
        {
            // Arrange
            BookingSystem bookingSystem = new BookingSystem();
            Patient patient = new Patient("Alireza", "KHH", "AK714@canterbury.ac.uk", "passwordP123gg");
            bookingSystem.RegisteredPatients.Add(patient);

            // Act
            bool result = bookingSystem.AttemptLogin("AK714@canterbury.ac.uk", "passwordP123gg");

            // Assert
            Assert.True(result);
            Assert.Equal(patient, bookingSystem.LoggedInPatient);
        }

        // Test for an unsuccessful login (invalid email)
        [Fact]
        public void AttemptLogin_InvalidEmail_ReturnsFalse()
        {
            // Arrange
            BookingSystem bookingSystem = new BookingSystem();

            // Act
            bool result = bookingSystem.AttemptLogin("invalidemail@example.com", "password");

            // Assert
            Assert.False(result);
            Assert.Null(bookingSystem.LoggedInPatient);
        }

        // Test for an unsuccessful login (invalid password)
        [Fact]
        public void AttemptLogin_InvalidPassword_ReturnsFalse()
        {
            // Arrange
            BookingSystem bookingSystem = new BookingSystem();
            Patient patient = new Patient("Alex", "Dave", "jane@example.com", "password123");
            bookingSystem.RegisteredPatients.Add(patient);

            // Act
            bool result = bookingSystem.AttemptLogin("jane@example.com", "invalidpassword");

            // Assert
            Assert.False(result);
            Assert.Null(bookingSystem.LoggedInPatient);
        }

    }

}