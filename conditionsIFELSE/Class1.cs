using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conditionsIFELSE
{
    // oppgave 1
    internal class Class1
    {
        public static bool TwoNumbers()
        {
            Console.WriteLine("write two numbers, are they equal or not?");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            bool isEqual = false;

            if (num1 == num2)
            {
                isEqual = true;
                Console.WriteLine("The numbers are equal");

            }
            else
            {
                isEqual = false;
                Console.WriteLine("The numbers are not equal");
              
                
            }
            return isEqual;

        }

        // oppgave 2
        public static bool TimesTwo()
        {
            Console.WriteLine("write two numbers, if they are equal you will (*) them, if they are different you'll (+) them:");
            int num3 = Convert.ToInt32(Console.ReadLine());
            int num4 = Convert.ToInt32(Console.ReadLine());

            bool isEqual = false;



            if (num3 == num4)
            {
                isEqual = true;
                int result = num3 * num4;
                Console.WriteLine($"The numbers are equal, so here they are ({num3} * {num4} = {result})");

                
                
            }
            else 
            { 
                isEqual = false;
                int result = num3 + num4;
                Console.WriteLine($"The numbers are different, so i got the sum of them:{num3} + {num4} = {result}");
                
            }
            return isEqual;
        }

        //oppgave 3

       public static bool TestingInt(int number1, int number2)
        {
            var sum = number1 + number2;
            var illegalNumber = 30;

            if (number1 == illegalNumber || number2 == illegalNumber || sum == illegalNumber)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    
}
