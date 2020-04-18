using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public static class StringToInt
    {
        public static void ConvertStringToInt()
        {
            Console.WriteLine("Enter the string to convert to int");
            string input = Console.ReadLine();
            int result = 0;
            for(int i =0;i<input.Length;i++)
            {               
                result = (result * 10) + Convert.ToInt32(input[i].ToString());
            }
            Console.WriteLine("Result : {0}",result);
            Console.ReadLine();
        }
    }
}
