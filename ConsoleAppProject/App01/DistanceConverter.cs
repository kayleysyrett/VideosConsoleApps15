
using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This app converts the distance 
    /// </summary>
    /// <author>
    /// Kayley Syrett version 0.1
    /// </author>
    public class DistanceConverter
    {
        private double miles;
        
        private double feet;

        /// <summary>
        /// This method will input the distance measured in miles
        /// calculate the same distance in feet, and output the 
        /// distance in feet.
        /// </summary>
        public void Run()
        {
            OutputHeading();
            InputMiles();
            CalculateFeet();
            OutputFeet();
        }

        private void OutputHeading()
        {
            Console.WriteLine("\n-------------------------------");
            Console.WriteLine("\n     Convert Miles to Feet     ");
            Console.WriteLine("\n       by Kayley Syrett        ");
            Console.WriteLine("\n-------------------------------\n");
        }

        /// <summary>
        /// Prompt the user to enter the distance
        /// Input the miles as a double number.
        /// </summary>
        private void InputMiles()
        {
            Console.Write("Please enter the number of miles > ");
            String value = Console.ReadLine();
            miles = Convert.ToDouble(value);
        }

        /// <summary>
        /// This class offers methods for converting a given 
        /// distance measured in miles to the equivalent
        /// distance measured in feet.
        /// </summary>
        private void CalculateFeet()
        {
            feet = miles * 5280;
        }

        /// <summary>
        /// This class will send the output to the screen
        /// in feet.
        /// </summary>
        private void OutputFeet()
        {
            Console.WriteLine(miles + " miles is " + feet + " feet!");
        }
    }

}
