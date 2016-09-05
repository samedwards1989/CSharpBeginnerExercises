using System;

namespace ControlFlow
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Exercise 1

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

            #endregion

            #region Exercise 2

            // Exercise 2
            // Write a program which takes two numbers from the console and displays the maximum of the two.

            //            try
            //            {
            //                Console.WriteLine("Enter any number");
            //                var input = Convert.ToInt32(Console.ReadLine());
            //                Console.WriteLine("Enter another number");
            //                var input2 = Convert.ToInt32(Console.ReadLine());
            //
            //                Console.WriteLine(input > input2 ? $"The biggest mumber is {input}" : $"The biggest mumber is {input2}");
            //            }
            //            catch (Exception e)
            //            {
            //
            //                Console.WriteLine(e);
            //         

            #endregion

            #region Exercise 3

            // Exercise 3
            // Write a program and ask the user to enter the width and height of an image. Then tell if the image is landscape or portrait.

            //            try
            //            {
            //                Console.WriteLine("Enter Width");
            //                var width = Convert.ToInt32(Console.ReadLine());
            //                Console.WriteLine("Enter Height");
            //                var height = Convert.ToInt32(Console.ReadLine());
            //
            //                if (width > height)
            //                    Console.WriteLine("The image is Landscape");
            //                else
            //                    Console.WriteLine("The image is Portrait");
            //
            //            }
            //            catch (Exception e)
            //            {
            //
            //                Console.WriteLine(e);
            //            }


            #endregion


            // Exercise 4
            // Your job is to write a program for a speed camera. For simplicity, ignore the details such as camera, sensors,
            // etc and focus purely on the logic. Write a program that asks the user to enter the speed limit.
            // Once set, the program asks for the speed of a car. If the user enters a value less than the speed limit,
            // program should display Ok on the console. If the value is above the speed limit, the program should calculate the number of demerit points.
            // For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on the console.
            // If the number of demerit points is above 12, the program should display License Suspended.

            try
            {
                Console.WriteLine("Please enter the speed limit");
                var limit = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the moving speed of the car");
                var speed = Convert.ToInt32(Console.ReadLine());
                if (speed <= limit)
                    Console.WriteLine("Ok");
                else
                {
                    var difference = speed - limit;
                    var demerit = difference / 5;
                    if (demerit <= 12)
                        Console.WriteLine($"You have incurred {demerit} points");
                    else
                        Console.WriteLine("Your license has been suspended");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }
    }
}

