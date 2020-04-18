using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public static class IntToBinary
    {
        public static void ConvertIntToBinary() 
        {
            int input = 0;string result = "";
            Console.WriteLine("Enter the integer to convert to Int");
            if(Int32.TryParse(Console.ReadLine(), out input) && input > 0)
            {               
                while (input > 1)
                {
                    result += Convert.ToString(input%2);
                    input = input / 2;
                }                
                Console.WriteLine("Binary format of the input is {0} ",input.ToString()+result);
            }
        }
    }
}
