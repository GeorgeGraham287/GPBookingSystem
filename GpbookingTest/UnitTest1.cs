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

        [Fact]
        public void ValidateEmail_InvalidEmail_ReturnsFalse()
        {
            Form1 f = new Form1();
            RegistrationForm form = new RegistrationForm(f,new BookingSystem());


            bool result = form.ValidateEmail("hello");

            Assert.False(result);
        }
        [Fact]
        public void ValidateEmail_ValidEmail_ReturnsTrue()
        {
            Form1 f = new Form1();
            RegistrationForm form = new RegistrationForm(f,new BookingSystem());

            bool result = form.ValidateEmail("GG287@canterbury.ac.uk");

            Assert.True(result);
        }
    }

}