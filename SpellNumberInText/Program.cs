using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpellNumberInText
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberToWordConverter converter = new NumberToWordConverter();
            int inputNumber = 112;
            string result = string.Empty;
            result = converter.ConvertToWords(inputNumber);
            Console.WriteLine(result);

            inputNumber = 190;
            result = converter.ConvertToWords(inputNumber);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
