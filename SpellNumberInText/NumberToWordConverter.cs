using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpellNumberInText
{
    public class NumberToWordConverter
    {
        /// <summary>
        /// Get one degit number in word formate
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
    }
}
