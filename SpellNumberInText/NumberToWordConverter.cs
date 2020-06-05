using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpellNumberInText
{
    /// <summary>
    /// Convert Number to Word 
    /// </summary>
    public class NumberToWordConverter
    {
        /// <summary>
        /// Get one degit number in word format
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        private string GetOneDegitNumberInWord(int number)
        {
            string name = "";
            switch (number)
            {

                case 1:
                    name = "One";
                    break;
                case 2:
                    name = "Two";
                    break;
                case 3:
                    name = "Three";
                    break;
                case 4:
                    name = "Four";
                    break;
                case 5:
                    name = "Five";
                    break;
                case 6:
                    name = "Six";
                    break;
                case 7:
                    name = "Seven";
                    break;
                case 8:
                    name = "Eight";
                    break;
                case 9:
                    name = "Nine";
                    break;
            }
            return name;
        }

        public string ConvertToWords(double inputNumber)
        {
            throw new NotImplementedException();
        }



        /// <summary>
        /// Get Two degit number in word format
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        private string GetTwoDegitNumberInWord(int number)
        {            
            string name = null;
            switch (number)
            {
                case 10:
                    name = "Ten";
                    break;
                case 11:
                    name = "Eleven";
                    break;
                case 12:
                    name = "Twelve";
                    break;
                case 13:
                    name = "Thirteen";
                    break;
                case 14:
                    name = "Fourteen";
                    break;
                case 15:
                    name = "Fifteen";
                    break;
                case 16:
                    name = "Sixteen";
                    break;
                case 17:
                    name = "Seventeen";
                    break;
                case 18:
                    name = "Eighteen";
                    break;
                case 19:
                    name = "Nineteen";
                    break;
                case 20:
                    name = "Twenty";
                    break;
                case 30:
                    name = "Thirty";
                    break;
                case 40:
                    name = "Fourty";
                    break;
                case 50:
                    name = "Fifty";
                    break;
                case 60:
                    name = "Sixty";
                    break;
                case 70:
                    name = "Seventy";
                    break;
                case 80:
                    name = "Eighty";
                    break;
                case 90:
                    name = "Ninety";
                    break;
                default:
                    if (number > 0)
                    {
                        name = GetTwoDegitNumberInWord(Convert.ToInt32(number.ToString().Substring(0, 1) + "0")) + " " + GetOneDegitNumberInWord(Convert.ToInt32(number.ToString().Substring(1)));
                    }
                    break;
            }
            return name;
        }


    }
}
