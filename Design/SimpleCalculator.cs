/*  Purpose:        Calculate the sum, difference, product, and quotient of two numbers
 *  
 *  Input:          2 numbers
 *  Output:         sum, difference, product, and quotient   
 *  
 *  Written by:     Dana Marsh
 *  Last modified:  2019.09.09
 */


using System;


namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare variables:
            double firstNumber, secondNumber, sum, difference, quotient, product;
            string userInput;

            // prompt user for input:
            Console.WriteLine("Welcome to the Simple Calculator!");
            Console.WriteLine("What is your first number?");
            userInput = Console.ReadLine();
            firstNumber = double.Parse(userInput);
            Console.WriteLine("What is your second number?");
            userInput = Console.ReadLine();
            secondNumber = double.Parse(userInput);
            Console.WriteLine("You entered {0} and {1}.", firstNumber, secondNumber);

            // calculate numbers:
            sum = firstNumber + secondNumber;
            difference = firstNumber - secondNumber;
            quotient = firstNumber / secondNumber;
            product = firstNumber * secondNumber;

            // display results:
            Console.WriteLine("\n{0} + {1} = {2}\n" +
                "{0} - {1} = {3}\n" +
                "{0} * {1} = {4}\n" +
                "{0} / {1} = approximately {5}\n" +
                "Press any key to exit.", firstNumber, secondNumber, sum, difference, product, Math.Round(quotient, 2));
            Console.ReadLine();

        }
    }
}
