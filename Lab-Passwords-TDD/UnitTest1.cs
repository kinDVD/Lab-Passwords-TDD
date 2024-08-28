using ConsoleApp1;
namespace Lab_Passwords_TDD
{
    public class UnitTest1
    {

        /*Test Cases/Rules: 
         * Write 2 tests for each of the following rules. 
         * Assert that the List is changed (or not changed) and 
         * assert that the method returns true or false.*/
        /*For a password to be valid, it must meet all of the following rules.
 *      The password doesn't already exist in the list
 *      The password is between 7 and 12 characters exclusive
 *      The password has at least one number,
 *              but any password with a 6 is not allowed
 *              Spaces are not permitted in passwords
 *      The password must contain at least 2 capital vowels (Count y as a vowel,
 *              repeated vowels are allowed like in BOOK or EYE)
 *      The words "admin" and "mod" may be used as passwords and
 *      ignores other rules save for one:
 *              the password should only be added if it isn't already in the list.*/


        [Theory]
        [InlineData("ChanningTatum", false)]
        [InlineData("mod", true)]
        [InlineData("PrInglE5", false)]
        [InlineData("123456789", false)]
        [InlineData("not", false)]
        [InlineData("ChAnningTatUm", false)]
        [InlineData("m1O    O2d", false)]

        public void TrueOrFalse(string password, bool expect)
        {
            //Arrange
            List<string> Passwords = new List<string> { "PrInglE5", "h4CkErShIt" };
            //Act
            bool passKey = PasswordStorage.AddPassword(password, Passwords);
            //Assert
            Assert.Equal(expect, passKey);
        }

        [Theory]
        [InlineData("ChanningTatum", false)]
        [InlineData("mod", true)]
        [InlineData("PrInglE5", false)]
        [InlineData("123456789", false)]
        [InlineData("not", false)]
        [InlineData("ChAnningTatUm", false)]
        [InlineData("m1O    O2d", false)]
        public void ListChanged(string password, bool expect)
        {
            //Arrange
            List<string> Passwords = new List<string> { "PrInglE5", "h4CkErShIt" };
            int listCount = Passwords.Count;
            //Act
            PasswordStorage.AddPassword(password, Passwords);
            bool listChange = Passwords.Count  > listCount || Passwords.Count < listCount;
            //Assert
            Assert.Equal(expect, listChange);
        }
    }
}