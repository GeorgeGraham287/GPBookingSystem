using GPBookingSystem;

namespace GpbookingTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //BookingSystem 
            //create instance for registrationform and validatepassword
            //one of the test to check for blank passworsds (Alwin)
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