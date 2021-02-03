
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
        /// This class will run the program and call
        /// on the three methods below.
        /// </summary>
        public void Run()
        {
            InputMiles();
            CalculateFeet();
            OutputFeet();
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

        }

        /// <summary>
        /// This class will send the output to the screen
        /// in feet.
        /// </summary>
        private void OutputFeet()
        {

        }
    }

}
