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
        
        static int CalculateFactorial(int n)
        {

            int result = n;

            if (result == 0)
            {
                result = 1;
                return result;
            }
            else
            {

                for (int i = 1; i < n; i++)
                {
                    result = result * (n - i);
                }

            }
                
       
            return result;
        }


        static void Main(string[] args)
        {
            int input = 5;
            int result = CalculateFactorial(input);
            Console.WriteLine("!{0} is {1}", input, result );
            Console.ReadKey();
        }
    }
}
