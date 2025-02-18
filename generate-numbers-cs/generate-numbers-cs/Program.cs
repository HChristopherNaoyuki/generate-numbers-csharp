using System;

namespace GenerateNumbersCs
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                // Create a Random object instance
                Random rnd = new Random();

                // Generate three random numbers between 1 and 6 (inclusive)
                int num1 = rnd.Next(1, 7);
                int num2 = rnd.Next(1, 7);
                int num3 = rnd.Next(1, 7);

                // Output the generated numbers to the console
                Console.WriteLine(num1);
                Console.WriteLine(num2);
                Console.WriteLine(num3);
            }
            catch (Exception ex)
            {
                // Handle any unexpected exceptions
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            finally
            {
                // Ensure that the program waits for a key press before exiting
                Console.ReadKey();
            }
        }
    }
}
