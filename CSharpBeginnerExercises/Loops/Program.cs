using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exercise 1
            // Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. Display the count on the console.

            //            var isDivisable = 0;
            //            var minValue = 1;
            //            var maxValue = 100;
            //            while (minValue <= maxValue)
            //            {
            //                if (minValue % 3 == 0)
            //                {
            //                    isDivisable++;
            //                }
            //                minValue++;
            //            }
            //            Console.WriteLine(isDivisable);
            #endregion

            #region Exercise 2

            // Write a program and continuously ask the user to enter a number or "ok" to exit.
            // Calculate the sum of all the previously entered numbers and display it on the console.

            //            var i = 0;
            //            var sum = 0;
            //            while (i == i)
            //            {
            //                Console.WriteLine("Enter a number or press 'ok' to exit");
            //                var input = Console.ReadLine();
            //                if (input.ToLower() != "ok")
            //                {
            //                    var number = Convert.ToInt32(input);
            //                    sum = sum + number;
            //                }
            //                else if (input.ToLower() == "ok")
            //                {
            //                    break;
            //                }
            //                i++;
            //            }
            //            Console.WriteLine($"Sum of all numbers: {sum}");

            #endregion

            #region Exercise 3

            // Write a program and ask the user to enter a number. Compute the factorial of the number and print it on the console.
            // For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.


            #endregion

            #region Exercise 4

            // Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number.
            // If the user guesses the number, display “You won"; otherwise, display “You lost". (To make sure the program is behaving correctly,
            // you can display the secret number on the console first.)

            var random = new Random();
            var chances = 1;
            var num = random.Next(1, 10);
            //Console.WriteLine(num);
            while (chances < 5)
            {
                Console.WriteLine("Guess the random number, you have 4 chances");
                var guess = Convert.ToInt32(Console.ReadLine());
                if (guess == num)
                {
                    Console.WriteLine("You win");
                    break;
                }

                else
                {
                    if (chances == 4)
                    {
                        Console.WriteLine("You Lose");
                        break;
                    }
                    Console.WriteLine("Wrong... Guess again");
                    chances++;
                }


            }


            #endregion

            #region Exercise 5

            // Write a program and ask the user to enter a series of numbers separated by comma. Find the maximum of the numbers and display it on the console.
            // For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.


            #endregion
        }
    }
}
