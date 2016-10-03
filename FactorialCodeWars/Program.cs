using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//CodeWars.com kata practice
//Write a function to calculate factorial for a given input. If input is below 0 or above 12 throw an exception of type ArgumentOutOfRangeException (C#)
 


namespace FactorialCodeWars
{

    public class IncorrectInputException : Exception
    {
        public IncorrectInputException()
        {
        }

        public IncorrectInputException(string message)
            : base(message)
        {
        }

        public IncorrectInputException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
    class Program
    {
        static int CalculateFactorial(int input)
        {
            int result = input;
            try
            {

                for (int i = 1; i < input; i++)
                {
                    result = result * (input - i);
                }

            }
            catch (IncorrectInputException e) when (input <= 0 || input > 12 )
            {
                Console.Clear();
                Console.WriteLine(e.Message("NO!!!"));
                Console.WriteLine("Press any key to repeat.");
                Console.ReadKey();
                //throw;
            }


            


            return result;
        }


        static void Main(string[] args)
        {
            int input = 13;
            int result = CalculateFactorial(input);
            Console.WriteLine("!{0} is {1}", input, result );
            Console.ReadKey();
        }
    }
}
