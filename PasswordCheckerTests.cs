using Microsoft.VisualStudio.TestTools.UnitTesting;
using CheckPassword__Smir__;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPassword__Smir__.Tests
{
    [TestClass()]
    public class PasswordCheckerTests
    {
        [TestMethod()]
        public void CheckPassword_ReturnsTest()
        {
            // Arrange
            string password = "Gosha2003!#";
            bool expected = true;

            //Act
            bool actual = PasswordChecker.ValidatePassword(password);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Check8Symbols_ReturnsTest()
        {
            // Arrange
            string password = "Gosha3333@";
            bool expected = true;

            //Act
            bool actual = PasswordChecker.ValidatePassword(password);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Check30Symbols_ReturnsTest()
        {
            // Arrange
            string password = "Goga2007Goga2007Goga2007###@!";

            //Act
            bool actual = PasswordChecker.ValidatePassword(password);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod()]
        public void Check_PasswordWithSpec_ReturnsFalse()
        {
            // Arrange
            string password = "Giga27022005#";
            bool expected = true;

            //Act
            bool actual = PasswordChecker.ValidatePassword(password);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Check_PasswordWithOutSpecSymbols_ReturnsFalse()
        {
            // Arrange
            string password = "Giga27022005";
            bool expected = false;

            // Act
            bool actual = PasswordChecker.ValidatePassword(password);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Check_IsUpper_ReturnsTrue()
        {
            // Arrange
            string password = "Grigor394!";
            bool expected = true;

            // Act
            bool actual = PasswordChecker.ValidatePassword(password);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Check_IsUpper_ReturnsFalse()
        {
            // Arrange
            string password = "grigor394!";
            bool expected = false;

            // Act
            bool actual = PasswordChecker.ValidatePassword(password);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Check_IsLower_ReturnsTrue()
        {
            // Arrange
            string password = "GOGa2005#";
            bool expected = true;

            // Act
            bool actual = PasswordChecker.ValidatePassword(password);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Check_IsLower_ReturnsFalse()
        {
            // Arrange
            string password = "GOGA2005#";
            bool expected = false;

            // Act
            bool actual = PasswordChecker.ValidatePassword(password);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}