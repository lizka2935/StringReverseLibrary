using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using StringReverseLibrary;

namespace StringReverseLibraryTests
{
    [TestClass]
    public class StringReversClassTests
    {
        [TestMethod]
        public void ReverseString_Privet_Tevirp()
        {
            //Arrange
            string textString = "Привет";
            string exement = "тевирп";
            //Act
            StringReversClass obj = new StringReversClass();
            string actual = obj.ReverseString(textString);
            //Assert
            Assert.AreEqual(exement, actual);
        }
        [TestMethod]
        public void ReverseString_EmptyLine_ReturnException()
        {
            //Arrange
            string textString = "";
            //Act
            StringReversClass obj = new StringReversClass();
            Action actual =()=> obj.ReverseString(textString);
            //Assert
            Assert.ThrowsException<Exception>(actual);
        }
        [TestMethod]
        public void ReverseString_qwerty_ytrewq()
        {
            //Arrange
            string textString = "qwerty";
            string exement = "ytrewq";
            //Act
            StringReversClass obj = new StringReversClass();
            string actual = obj.ReverseString(textString);
            //Assert
            Assert.AreEqual(exement, actual);
        }
        [TestMethod]    
        public void ReverseString_Qwerty_ytrewq()
        {
            //Arrange
            string textString = "Qwerty";
            string exement = "ytrewq";
            //Act
            StringReversClass obj = new StringReversClass();
            string actual = obj.ReverseString(textString);
            //Assert
            Assert.AreEqual(exement, actual);
        }

        [DataTestMethod]
        [DataRow("Привет!", "!тевирп")]
        public void Priver (string textString, string exement)
        {
            StringReversClass obj = new StringReversClass();
            string actual = obj.ReverseString(textString);
            Assert.AreEqual(exement, actual);

        }
    }
}
