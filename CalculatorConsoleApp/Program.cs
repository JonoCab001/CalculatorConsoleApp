using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variable Definitions while values are assigned to zero
            double numb1 = 0;
            double numb2 = 0;

            // Display the title as the C# Console calculator app
            Console.WriteLine("Console Calculator written in C#\r");
            Console.WriteLine("--------------------------------\n");

            // Prompt the user to type in their first number
            Console.WriteLine("Please enter a number: ");
            numb1 = Convert.ToDouble(Console.ReadLine());

            // Prompt the user to type in their second number
            Console.WriteLine("Please enter another number: ");
            numb2 = Convert.ToDouble(Console.ReadLine());

            // Prompt the user to select an option
            Console.WriteLine("Select an option from the following list below:");
            Console.WriteLine("\t+ - Add");
            Console.WriteLine("\t- - Subtract");
            Console.WriteLine("\t* - Multiply");
            Console.WriteLine("\t/ - Divide");
            Console.Write("Your option?: ");

            // Switch statment for doing the calculation
            switch (Console.ReadLine())
            {
                case "+":
                    Console.WriteLine($"Result: {numb1} + {numb2} = " + (numb1 + numb2));
                    break;
                case "-":
                    Console.WriteLine($"Result: {numb1} - {numb2} = " + (numb1 - numb2));
                    break;
                case "*":
                    Console.WriteLine($"Result: {numb1} * {numb2} = " + (numb1 * numb2));
                    break;
                case "/":
                    // Ask the user to enter a non-zero divisor until they do so.
                    while (numb2 == 0)
                    {
                        Console.WriteLine("Enter a non-zero divisor: ");
                        numb2 = Convert.ToDouble(Console.ReadLine());
                    }
                    Console.WriteLine($"Result: {numb1} / {numb2} = " + (numb1 / numb2));
                    break;
            }

            // Wait for user to respond before closing the application
            Console.Write("\nPress any key to close the application...");
            Console.ReadKey();
        }
    }
}
