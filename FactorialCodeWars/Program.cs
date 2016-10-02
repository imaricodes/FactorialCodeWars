using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//CodeWars.com kata practice
//Write a function to calculate factorial for a given input. If input is below 0 or above 12 throw an exception of type ArgumentOutOfRangeException (C#)
 


namespace FactorialCodeWars
{
    class Program
    {
        static int CalculateFactorial(int input)
        {
            int result = 0;

            for (int i = input; i < 0; i--)
            {
                result = input * input - 1;
            }


            return result;
        }


        static void Main(string[] args)
        {
            int input = 5;
            int result = CalculateFactorial(input);
            Console.WriteLine("The factorial of {0} = {1} " , input, result );
            Console.ReadKey();
        }
    }
}
