using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibraryPassword;

namespace PasswordChekerTests
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Корректный пароль
        /// </summary>
        [TestMethod]
        public void Check_85Symbols_returnsTrue()
        {
            //Arrange
            string password = "ASqw12$$";
            bool expected = true;
            //Act
            PasswordCheker obj= new PasswordCheker();   
            bool actual = obj.ValidatePassword(password);
            //Assert
            Assert.AreEqual(expected, actual); 
        }
        /// <summary>
        /// пустая строка
        /// </summary>
        [TestMethod]
        public void Check_PasswordIsEmpty_returnsFalse()
        {
            //Arrange
            string password = "";
            bool expected = false;
            //Act
            PasswordCheker obj = new PasswordCheker();
            bool actual = obj.ValidatePassword(password);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// 4 символа
        /// </summary>
        [TestMethod]
        public void Check_45Symbols_returnsFalse()
        {
            //Arrange
            string password = "Aq1$";
            //Act
            PasswordCheker obj = new PasswordCheker();
            bool actual = obj.ValidatePassword(password);
            //Assert
            Assert.IsFalse(actual);
        }
        /// <summary>
        /// короткий пароль 
        /// </summary>
        [TestMethod]
        public void Check_4Symbols_returnsFalse()
        {
            //Arrange
            string password = "AQs12";
            bool expected = false;
            //Act
            PasswordCheker obj = new PasswordCheker();
            bool actual = obj.ValidatePassword(password);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// без строчных букв
        /// </summary>
        [TestMethod]
        public void Check_PasswordWithoutLowerSymbols_returnsFalse()
        {
            //Arrange
            string password = "AQSDF12$";
            bool expected = false;
            //Act
            PasswordCheker obj = new PasswordCheker();
            bool actual = obj.ValidatePassword(password);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// без заглавных букв
        /// </summary>
        [TestMethod]
        public void Check_PasswordfewSymbols_returnsFalse()
        {
            //Arrange
            string password = "jhergdvx13$";
            bool expected = false;
            //Act
            PasswordCheker obj = new PasswordCheker();
            bool actual = obj.ValidatePassword(password);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// бзе цифр
        /// </summary>
        [TestMethod]
        public void Check_PasswordWithoutNumbers_returnsFalse()
        {
            //Arrange
            string password = "AQSddsff$";
            bool expected = false;
            //Act
            PasswordCheker obj = new PasswordCheker();
            bool actual = obj.ValidatePassword(password);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// без спец.символов
        /// </summary>
        [TestMethod]
        public void Check_PasswordWithoutSepcSymbols_returnsFalse()
        {
            //Arrange
            string password = "AQSdf123";
            bool expected = false;
            //Act
            PasswordCheker obj = new PasswordCheker();
            bool actual = obj.ValidatePassword(password);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// больше 20 символов
        /// </summary>
        [TestMethod]
        public void Check_PasswordManySymbols_returnsFalse()
        {
            //Arrange
            string password = "AQSdgfhjdgbfdhkhfiuasugff123$";
            bool expected = false;
            //Act
            PasswordCheker obj = new PasswordCheker();
            bool actual = obj.ValidatePassword(password);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        

    }
}
