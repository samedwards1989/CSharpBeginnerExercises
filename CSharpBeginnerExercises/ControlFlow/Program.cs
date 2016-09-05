using System;

namespace ControlFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1
            // Write a program and ask the user to enter a number.The number should be between 1 to 10.
            // If the user enters a valid number, display "Valid" on the console.Otherwise, display "Invalid".
            // (This logic is used a lot in applications where values entered into input boxes need to be validated.)

            //            Console.WriteLine("Enter a number between 1 and 10");
            //            var input = Console.ReadLine();
            //            try
            //            {
            //                var number = Convert.ToInt32(input);
            //
            //                if (number < 1 || number > 10)
            //                    Console.WriteLine("Invalid");
            //                else
            //                    Console.WriteLine("Valid");
            //            }
            //            catch (Exception e)
            //            {
            //
            //                Console.WriteLine(e);
            //            }

            // Exercise 2
            // Write a program which takes two numbers from the console and displays the maximum of the two.
            try
            {
                Console.WriteLine("Enter any number");
                var input = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter another number");
                var input2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(input > input2 ? $"The biggest mumber is {input}" : $"The biggest mumber is {input2}");
            }
            catch (Exception e)
            {

                Console.WriteLine(e);
            }

        }
    }
}
