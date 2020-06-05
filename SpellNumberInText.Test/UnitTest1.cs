using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SpellNumberInText.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod_ConvertToWords_TwoDigit()
        {
            int inputNumber = 99;
            string expectedResult = "Ninety Nine Only";  
            
            NumberToWordConverter numberToWordConverter = new NumberToWordConverter();
            string actualResult = numberToWordConverter.ConvertToWords(inputNumber);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod_ConvertToWords_ZeroAndOthers()
        {
            int inputNumber1 = 0, inputNumber2 = 13456;
            string expectedOutput1 = "Zero Only";
            string expectedOutput2 = "Thirteen Thousand Four Hundred Fifty Six Only";

            NumberToWordConverter converter = new NumberToWordConverter();
            string actualOutput1 = converter.ConvertToWords(inputNumber1);
            string actualOutput2 = converter.ConvertToWords(inputNumber2);


            Assert.AreEqual(expectedOutput1, actualOutput1);
            Assert.AreEqual(expectedOutput2, actualOutput2);
        }
    }
}
