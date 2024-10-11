using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            {
                // Declare two variables
                Console.Write("Enter the first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                // Perform arithmetic operations
                double addition = num1 + num2;
                double subtraction = num1 - num2;
                double multiplication = num1 * num2;
                double division = num2 != 0 ? num1 / num2 : double.NaN; // Handle division by zero
                double balance = Math.Abs(num1 - num2); // Absolute difference

                // Print the results
                Console.WriteLine("\nResults:");
                Console.WriteLine($"Addition: {num1} + {num2} = {addition}");
                Console.WriteLine($"Subtraction: {num1} - {num2} = {subtraction}");
                Console.WriteLine($"Multiplication: {num1} * {num2} = {multiplication}");
                Console.WriteLine($"Division: {num1} / {num2} = {(double.IsNaN(division) ? "Undefined (cannot divide by zero)" : division.ToString())}");
                Console.WriteLine($"Balance (absolute difference): |{num1} - {num2}| = {balance}");
                Console.ReadKey();
                }
        }
    }
}
