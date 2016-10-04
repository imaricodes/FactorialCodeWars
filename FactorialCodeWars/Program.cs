using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//CodeWars.com kata practice
//Write a function to calculate factorial for a given input. If input is below 0 or above 12 throw an exception of type ArgumentOutOfRangeException (C#)
 


namespace FactorialCodeWars
{
    //may not need this custom exception class
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
        //this does not work as intended
        static int CalculateFactorial(int input)
        {
            bool flag = true;
            int result = input;
            while (flag)
            {
                Console.Clear();
                Console.WriteLine("Enter a number");
                result = int.Parse( Console.ReadLine());

            }
            if (input <=0 || input > 12)
            {
                try
                {
                    throw new ArgumentOutOfRangeException();
                }
                catch (ArgumentOutOfRangeException e)
                {

                    Console.WriteLine("Input must be more than zero and less than 13!");
                    Console.WriteLine("Press any key to contiue");
                }
             
            }
            else
            {
                
                for (int i = 1; i < input; i++)
                {
                    result = result * (input - i);
                }

            }

            flag = false;
            Console.ReadKey();
         

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
