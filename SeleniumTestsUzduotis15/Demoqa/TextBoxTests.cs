using NUnit.Framework;
using SeleniumFrameworkUzduotis15;
using System;

namespace SeleniumTestsUzduotis15.Demoqa
{
    internal class TextBoxTests
    {
        [Test]
        public void FourInputFields()
        {
            string fullName = "Simas Simaitis";
            string email = "simas.simaitis@gmail.com";
            string currentAddress = "Palanga";
            string permanentAddress = "Vilnius";
            string expectedResult = "Full Name: Simas Simaitis\nEmail: simas.simaitis@gmail.com\nCurrent Address: Palanga\nPermanent Address: Vilnius";

            Driver.InitializeDriver();
            TextBoxTests.Open();

            TextBoxTests.EnterFullName(fullName);
            TextBoxTests.EnterEmail(email);
            TextBoxTests.EnterCurrentAddress(currentAddress);
            TextBoxTests.EnterPermanentAddress(permanentAddress);
            TextBoxTests.ClickSubmit();
            string actualResult = TextBoxTests.GetSubmit();

            Assert.AreEqual(expectedResult, actualResult);
        }

        private static void Open()
        {
            throw new NotImplementedException();
        }

        private static string GetSubmit()
        {
            throw new NotImplementedException();
        }

        private static void ClickSubmit()
        {
            throw new NotImplementedException();
        }

        private static void EnterPermanentAddress(string permanentAddress)
        {
            throw new NotImplementedException();
        }

        private static void EnterCurrentAddress(string currentAddress)
        {
            throw new NotImplementedException();
        }

        private static void EnterEmail(string email)
        {
            throw new NotImplementedException();
        }

        private static void EnterFullName(string fullName)
        {
            throw new NotImplementedException();
        }
    }
}
