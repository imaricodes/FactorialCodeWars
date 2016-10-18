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
            else if (result < 0 || result > 12)
            {
                throw new ArgumentOutOfRangeException();
               
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
            for (int i = 0; i <= 12; i++)
            {
                CalculateFactorial(i);
            }

            CalculateFactorial(1);
          
            Console.ReadKey();
        }
    }
}
