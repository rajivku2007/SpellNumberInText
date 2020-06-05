using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SpellNumberInText.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod_ConvertToWords()
        {
            double inputNumber = 9;
            string expectedResult = "Nine";           
            NumberToWordConverter numberToWordConverter = new NumberToWordConverter();
            string actualResult = numberToWordConverter.ConvertToWords(inputNumber);
        }
    }
}
