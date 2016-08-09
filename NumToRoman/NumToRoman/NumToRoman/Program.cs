using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumToRoman
{
    class A
    {
        static void Main(string[] args)
        {
            int number;
            string output;
            //Getting input and storing it in number
            Console.Write("Enter a Number : ");
            number = int.Parse(Console.ReadLine());

            //Validating Input values and passing it to the function.
            if (number == 0 || number < 0)
            {
                Console.WriteLine("Please enter a valid inuput");
            }

            else if (number > 3000)
            {
                Console.WriteLine("the number is greater than the calculater to handle");



            }

            else
            {
                output = ToRoman(number);
                Console.Write(output);

            }
            Console.Read();

        }

        //function to convert numbers to roman 
        public static string ToRoman(int number)
        {
            if (number < 1) return "";
            if (number >= 1000) return "M" + ToRoman(number - 1000);
            if (number >= 900) return "CM" + ToRoman(number - 900);
            if (number >= 500) return "D" + ToRoman(number - 500);
            if (number >= 400) return "CD" + ToRoman(number - 400);
            if (number >= 100) return "C" + ToRoman(number - 100);
            if (number >= 90) return "XC" + ToRoman(number - 90);
            if (number >= 50) return "L" + ToRoman(number - 50);
            if (number >= 40) return "XL" + ToRoman(number - 40);
            if (number >= 10) return "X" + ToRoman(number - 10);
            if (number >= 9) return "IX" + ToRoman(number - 9);
            if (number >= 5) return "V" + ToRoman(number - 5);
            if (number >= 4) return "IV" + ToRoman(number - 4);
            if (number >= 1) return "I" + ToRoman(number - 1);
            else throw new Exception("Unexpected error.");
        }

    }
}


