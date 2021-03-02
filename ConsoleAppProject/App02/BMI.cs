using System;
using System.Collections.Generic;
using System.Text;

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

        public double Index { get; set; }
        public string who;

        public double Centimetres;
        public double Inches;
        public double Kilograms { get; set; }
        public double Metres { get; set; }
        public double Pounds { get; set; }
        public double Stone { get; set; }
        public double Bmi { get; set; }

        public void Run()
        {
                Heading();
                string unit = SelectUnit();


                if (unit == "metric")
                {
                    Centimetres = InputMetricHeight();
                    Metres = Centimetres / 100;
                    Kilograms = InputMetricWeight();
                    CalculateMetric();


                }
                else
                {
                    Inches = InputImperialHeight();
                    Pounds = InputImperialWeight();
                    CalculateImperial();

                }

               OutputBmi();
               // CalculateWho();
                //OutputWho();
                //OutputWarning();
        }
        private void Heading()
        {
            Console.WriteLine("\n-------------------------------");
            Console.WriteLine("\n        BMI Calculator         ");
            Console.WriteLine("\n       by Kayley Syrett        ");
            Console.WriteLine("\n-------------------------------\n");
        }

        private string SelectUnit(string prompt)
        {
            string choice = DisplayChoices(prompt);

            string unit = ExecuteChoice(choice);
            Console.WriteLine($"\n You have chosen {unit}");
            return unit.ToLower();
        }

        public void OutputBmi()
        {
            Console.WriteLine($"Your current BMI is {Index:0.00}");
        }
        private void OutputHeading()
        {
            Console.WriteLine("\n-------------------------------");
            Console.WriteLine("\n        Welcome to the         ");
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
        private string SelectUnit()
        {

            Console.WriteLine("Please select metric or imperial units > ");
            string choice = DisplayChoices();

            string unit = ExecuteChoice(choice);
            Console.WriteLine($" You have chosen {unit}");
            return unit.ToLower();
        }
        private static string DisplayChoices()
        {
            Console.WriteLine();
            Console.WriteLine($"1. {METRIC}");
            Console.WriteLine($"2. {IMPERIAL}");

            Console.WriteLine();
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

        private double InputMetricHeight()
        {
            Console.Write("Please enter your height in Centimeters > ");
            string value = Console.ReadLine();
            return Convert.ToDouble(value);
        }

        private double InputMetricWeight()
        {
            Console.Write("Please enter your weight in Kilograms > ");
            string value = Console.ReadLine();
            return Convert.ToDouble(value);
        }

        private double InputImperialHeight()
        {
            Console.Write("Please enter your height in Inches > ");
            string value = Console.ReadLine();
            return Convert.ToDouble(value);
        }

        private double InputImperialWeight()
        {

            Console.Write("Please enter your weight in pounds > ");
            string value = Console.ReadLine();
            return Convert.ToDouble(value);
        }

        public void CalculateImperial()
        {
            //Index = (double)Pounds * Metric_Conversion / (Inches * Inches);
        }

        public void CalculateMetric()
        {
            Index = (Kilograms / (Metres * Metres));
        }

        private void OutputBodyMassIndex()
        {
            Console.WriteLine("Your BMI status is : ");
            //if statement required 
        }
    }
}
