
using System;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This app will prompt the user to input a distance 
    /// measured in one unit (fromUnit) and it will calculate and
    /// Output the equivalent distance in another unit (toUnit).
    /// </summary>
    /// <author>
    /// Kayley Syrett version 0.3
    /// </author>
    /// 

    // Distance conversion constants

    public class DistanceConverter
    {
        public const int FEET_IN_MILES = 5280;

        public const double METRES_IN_MILES = 1609.34;

        public const double FEET_IN_METRES = 3.28084;

        //public const double MILES_IN_METRES = 0.000621; 

        // Distance Unit Names 

        public const string FEET = "Feet";
        public const string MILES = "Miles";
        public const string METRES = "Metres";


    // Distance variables 

        public double FromDistance { get; set; }
        
        public double ToDistance { get; set; }

        // Unit variables 
        public DistanceUnits FromUnit { get; set; }

        public DistanceUnits ToUnit { get; set; }

        public DistanceConverter()
        {
            FromUnit = DistanceUnits.Miles;
            ToUnit = DistanceUnits.Feet;
        }

        /// <summary>
        /// This method will input the distance chosen by the
        /// user and calculate the output
        /// </summary>
        ///
        public void ConvertDistance()
        {
            ConsoleHelper.OutputHeading("Distance Converter");

            FromUnit = SelectUnit(" Please select from distance unit > ");
            ToUnit = SelectUnit(" Please select the to distance unit > ");

            Console.WriteLine($" Converting {FromUnit} to {ToUnit}");

            FromDistance = ConsoleHelper.InputNumber($" Please enter the number of {FromUnit} > ");

            CalculateDistance();

            OutputDistance();
        }

        public void CalculateDistance()
        {
            //convert distance from miles to feet 
            //
            if(FromUnit == MILES && ToUnit == FEET)
            {
                ToDistance = FromDistance * FEET_IN_MILES;
            }
            else if(FromUnit == FEET && ToUnit == MILES)
            {
                ToDistance = FromDistance / FEET_IN_MILES;
            }

            //convert distance from metres to feet 
            //
            if (FromUnit == METRES && ToUnit == FEET)
            {
                ToDistance = FromDistance * FEET_IN_METRES;
            }
            else if (FromUnit == FEET && ToUnit == METRES)
            {
                ToDistance = FromDistance / FEET_IN_METRES;
            }

            //convert distance from miles to metres
            //
            if (FromUnit == MILES && ToUnit == METRES)
            {
                ToDistance = FromDistance * METRES_IN_MILES;
            }
            //Convert Metres to Miles
            else if (FromUnit == METRES && ToUnit == MILES)
            {
                ToDistance = FromDistance / METRES_IN_MILES;
            }  
        }

        /// <summary>
        /// Display a menu of distance units and then prompt the 
        /// user to select one and return it. 
        /// </summary>
        /// 

        private string SelectUnit(string prompt)
        {
            string choice = DisplayChoices(prompt);

            string unit = ExecuteChoice(choice);
            Console.WriteLine($"\n You have chosen {unit}");
            return unit;
        }
        
        /// <summary>
        /// 
        /// </summary>       
        private string ExecuteChoice(string choice)
        {
            if (choice == "1")
            {
                return FEET;
            }
            else if (choice == "2")
            {
                return METRES;
            }
            else if (choice == "3")
            {
                return MILES;
            }
            else
            {
                Console.WriteLine("                                    ");
                Console.WriteLine("       ***ERROR MESSAGE***          ");
                Console.WriteLine("You have not selected a valid option");
                Console.WriteLine("        Please try again...         ");
                return null;
            }
        }

        private static string DisplayChoices(string prompt)
        {
            Console.WriteLine();
            Console.WriteLine($" 1. {FEET}");
            Console.WriteLine($" 2. {METRES}");
            Console.WriteLine($" 3. {MILES}");
            Console.WriteLine();
            
            Console.Write(prompt);
            string choice = Console.ReadLine();
            return choice;
        }

        /// <summary>
        /// Prompt the user to enter the distance 
        /// </summary>
        private double InputDistance(string prompt)
        {
            Console.Write(prompt);
            String value = Console.ReadLine();
            return Convert.ToDouble(value);
        }

        private void OutputDistance()
        {
            Console.WriteLine($"\n {FromDistance}  {FromUnit}" +
                $" is {ToDistance} {ToUnit}!\n");
        }

        /// <summary>
        /// Output a short description of the application 
        /// and the name of the author and prompt to
        /// inform the use which units are being converted.
        /// </summary>
        /// 
        private void OutputHeading()
        {
            Console.WriteLine("\n-------------------------------");
            Console.WriteLine("\n     Distance Converter        ");
            Console.WriteLine("\n       by Kayley Syrett        ");
            Console.WriteLine("\n-------------------------------\n");
        }

    } 

}
