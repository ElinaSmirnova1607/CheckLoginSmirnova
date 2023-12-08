using Microsoft.VisualStudio.TestTools.UnitTesting;
using CheckLoginSmir;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckLoginSmir.Tests
{
    [TestClass()]
    public class LoginCheckerTests
    {
        [TestMethod()]
        public void Check4Symbols_ReturnsTest()
        {
            // Arrange
            string login = "Alex";
            bool expected = true;

            //Act
            bool actual = LoginChecker.ValidateLogin(login);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Check2Symbols_ReturnsTest()
        {
            // Arrange
            string login = "BH";

            //Act
            bool actual = LoginChecker.ValidateLogin(login);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod()]
        public void Check155Symbols_ReturnsFalse()
        {
            // Arrange
            string login = "ChrissRashordLensi";
            bool expected = false;

            //Act
            bool actual = LoginChecker.ValidateLogin(login);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Check_LoginWithSpec_ReturnsFalse()
        {
            // Arrange
            string login = "Abram#";
            bool expected = false;

            //Act
            bool actual = LoginChecker.ValidateLogin(login);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CheckLoginWithOutSpecSymbols_ReturnsTrue()
        {
            // Arrange
            string login = "Abram";
            bool expected = true;

            //Act
            bool actual = LoginChecker.ValidateLogin(login);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}