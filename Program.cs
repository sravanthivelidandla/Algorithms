using System;
using System.Collections.Generic;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            //IntToBinary.ConvertIntToBinary();
            //ConvertIntToString();
            StringToInt.ConvertStringToInt();
        }

        private static void ConvertIntToString()
        {
            int input = 0;
            string result = "";
            List<char> output = new List<char>();
            Console.WriteLine("enter the number to convert to String");
            bool isInt = int.TryParse(Console.ReadLine(), out input);
            try
            {
                if (isInt)
                {
                    while (input > 10)
                    {
                        result=toChar(input % 10)+result;
                        input = input / 10;
                    }
                    result = input.ToString() + result;
                }
                Console.WriteLine("Int in String \"{0}\"", result);
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Occured" + ex);
            }
        }

        static char toChar(int input)
        {           
            switch (input)
            {
                case 0: return '0';
                case 1: return '1';
                case 2: return '2';
                case 3: return '3';
                case 4: return '4';
                case 5: return '5';
                case 6: return '6';
                case 7: return '7';
                case 8: return '8';
                case 9: return '9';
                default: return '\0';
            }
            
        }
    }
}
