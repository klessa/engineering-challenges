using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ParsePhoneNumbers.UnitTest
{
    [TestClass]
    public class ParsePhoneNumbersTest
    {     
        [TestMethod]
        public void containsPhoneNumberParenTest()
        {
            bool phoneFound = ParsePhoneNumbers.Program.containsPhoneNumber("this is my number (333)888-3333");
            Assert.AreEqual(true, phoneFound);
        }

        [TestMethod]
        public void containsPhoneNumberNoParenTest()
        {
            bool phoneFound = ParsePhoneNumbers.Program.containsPhoneNumber("this phone number has only dashes 333-444-4555");
            Assert.AreEqual(true, phoneFound);
        }

        [TestMethod]
        public void containsInvalidPhoneNumberTest()
        {
            bool phoneFound = ParsePhoneNumbers.Program.containsPhoneNumber("this phone number has an extra dash (333)-432-3030");
            Assert.AreEqual(false, phoneFound);
        }

        [TestMethod]
        public void containsMissingNumberTest()
        {
            bool phoneFound = ParsePhoneNumbers.Program.containsPhoneNumber("this number is missing digits (333)32-3829");
            Assert.AreEqual(false, phoneFound);
        }

    }
}
