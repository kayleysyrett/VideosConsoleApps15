using System;


namespace ConsoleAppProject.App02
{
    /// <summary>
    /// This app will prompt the user to enter their height entered in 
    /// one unit where it will calculate and output their BMI and the
    /// WHO weight status in another unit.
    /// </summary>
    /// <author>
    /// Kayley Syrett version 0.1
    /// </author>
    public class BMIConverter
    {
        public const double Underweight = 18.5;
        public const double Normal = 24.9;
        public const double Overwight = 29.9;
        public const double ObeseLevel1 = 34.9;
        public const double ObeseLevel2 = 39.9;
        public const double ObeseLevel3 = 40.0;

        public const int InchesInFeet = 12;
        public const int PoundsInStones = 14;

        public const string METRIC = "metric";
        public const string IMPERIAL = "imperial";

        public void Run()
        {
            SelectUnit("Please enter your choice ");
        }
        private string SelectUnit(string prompt)
        {
            string choice = DisplayChoices(prompt);

            string unit = ExecuteChoice(choice);
            Console.WriteLine($"\n You have chosen {unit}");
            return unit;
        }

        public BMIConverter()
        {

        }
        private void OutputHeading()
        {
            Console.WriteLine("\n-------------------------------");
            Console.WriteLine("\n  Body Mass Index Calculator   ");
            Console.WriteLine("\n       by Kayley Syrett        ");
            Console.WriteLine("\n-------------------------------\n");
        }

        private static string DisplayChoices(string prompt)
        {
            Console.WriteLine();
            Console.WriteLine($" 1. {METRIC}");
            Console.WriteLine($" 2. {IMPERIAL}");
            Console.WriteLine();

            Console.Write(prompt);
            string choice = Console.ReadLine();
            return choice;
        }

       
        private string ExecuteChoice(string choice)
        {
            if (choice == "1")
            {
                return METRIC;
            }
            else if (choice == "2")
            {
                return IMPERIAL;
            }
            else
            {
                Console.WriteLine("You have not selected a valid option");
                return null;
            }
        }

        private void CalculateBodyMassIndexImperial()
        {
            Console.WriteLine("Please enter your height in feet : ");
            Console.WriteLine("Please enter your height in inches : ");
            double height = Convert.ToDouble(Console.ReadLine()); // ask derek if correct/ok (two commands on one line?)
        }

        private void CalculateBodyMassIndexMetric()
        {
            Console.WriteLine("Please enter your height in cm : ");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter your weight in kg : ");
            double weight = Convert.ToDouble(Console.ReadLine());
        }
        private void OutputBodyMassIndex()
        {
            Console.WriteLine("Your BMI status is : ");
            //if statement required 
        }
    }
}
