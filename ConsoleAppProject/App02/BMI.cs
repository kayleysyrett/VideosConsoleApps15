using System;
using System.Collections.Generic;
using System.Text;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App02
{
    /// <summary>
    /// This app will prompt the user to enter their height and weight
    /// in either imperial or metric units, then calculate and output the 
    /// users BMI, their WHO weight status and display a risk warning 
    /// message.
    /// </summary>
    /// <author>
    /// Kayley Syrett version 0.3
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
        public double Feet { get; set; }

        public double Pounds { get; set; }
        public double Stones { get; set; }
        public double Bmi { get; set; }
        public double Metric_Conversion { get; private set; }

        /// <summary>
        /// Prompt the user to select Imperial or Metric units.
        /// Input the user's height and weight and then calculate
        /// their BMI value. Output which weight the category
        /// falls into.
        /// </summary>
        public void Run()
        {
            ConsoleHelper.OutputHeading("BMI Converter");
            string unit = SelectUnit();

            if (unit == METRIC)
            {
                InputMetricHeight();
                Metres = Centimetres / 100;
                InputMetricWeight();
                CalculateMetric();
            }
            else
            {
                InputImperialHeight();
                InputImperialWeight();
                CalculateImperial();
            }

            OutputBmi();
            CalculateWho();
            OutputWho();
            OutputRisk();
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

        /// <summary>
        /// Output a short description of the application 
        /// and the name of the author.
        /// </summary>
        /// 
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

        /// <summary>
        /// Display a menu of measurement units and then prompt the 
        /// user to select one and return it. 
        /// </summary>
        /// 
        private string SelectUnit()
        {

            Console.WriteLine("                                                      ");
            string choice = DisplayChoices("Please select metric or imperial units > ");

            string unit = ExecuteChoice(choice);
            Console.WriteLine($" You have chosen {unit}");
            return unit.ToLower();
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

        /// <summary>
        /// Prompt the user to enter height in metric 
        /// </summary>
        private void InputMetricHeight()
        {
            Centimetres = ConsoleHelper.InputNumber("Please enter your height in Centimeters > ");
        }

        /// <summary>
        /// Prompt the user to enter weight in metric 
        /// </summary>
        private void InputMetricWeight()
        {
            Kilograms = ConsoleHelper.InputNumber("Please enter your weight in Kilograms > ");
        }

        /// <summary>
        /// Prompt the user to enter height in imperial 
        /// </summary>
        private void InputImperialHeight()
        {
            Feet = ConsoleHelper.InputNumber("Please enter your height in Feet > ");
            Inches = ConsoleHelper.InputNumber("Please enter your height in Inches > ");
        }

        /// <summary>
        /// Prompt the user to enter weight in imperial 
        /// </summary>
        private void InputImperialWeight()
        {
            Stones = ConsoleHelper.InputNumber("Please enter your weight in Stones > ");
            Pounds = ConsoleHelper.InputNumber("Please enter your weight in pounds > ");
        }

        /// <summary>
        /// Calculate imperial conversion 
        /// </summary>
        public void CalculateImperial()
        {
            Inches = Inches + Feet * InchesInFeet;
            Pounds = Pounds + Stones * PoundsInStones;
            Index = (double)Pounds * 703 / (Inches * Inches); 
        }

        /// <summary>
        /// Calculate metric conversion 
        /// </summary>
        public void CalculateMetric()
        {
            Metres = Centimetres / 100;
            Index = (Kilograms / (Metres * Metres));
        }

        /// <summary>
        /// Calculate WHO weight status
        /// </summary>
        public void CalculateWho()
        {
            Console.WriteLine("\n-----------------------------------------------------");
            Console.WriteLine("\n                                                     ");
            if (Index < 18.5)
            {
                who = "You are Underweight";
            }
            else if (Index >= 18.5 && Index <= 24.9)
            {
                who = "Congratulations you are Healthy!";
            }
            else if (Index >= 25.0 && Index <= 29.9)
            {
                who = "You are Overweight";
            }
            else if (Index >= 30.0 && Index <= 34.9)
            {
                who = "You are in the Obese Category 1";
            }
            else if (Index >= 35.0 && Index <= 39.9)
            {
                who = "You are in the Obese Category 2";
            }
            else if (Index >= 40.0)
            {
                who = "You are in the Obese Category 3";
            }
        }

        /// <summary>
        /// Output users current WHO weight status
        /// </summary>
        public void OutputWho()
        {
            Console.WriteLine("Your current WHO (World Health Organisation) weight status is as follows...  "  + who);
        }

        /// <summary>
        /// Output risk information 
        /// </summary>
        public void OutputRisk()
        {
            Console.WriteLine("\n-----------------------------------------------------");
            Console.WriteLine("\n                    Please note                      ");
            Console.WriteLine("\n              You may be at extra risk               ");
            Console.WriteLine("\n          if you are one of the following:           ");
            Console.WriteLine("\n                                                     ");
            Console.WriteLine("\n       Adult BMI 23.0 or more = increased risk       ");
            Console.WriteLine("\n         Adult BMI 27.5 or more = higher risk        ");
            Console.WriteLine("\n                                                     ");
            Console.WriteLine("\n                     Children                        ");
            Console.WriteLine("\n                     Pregnant                        ");
            Console.WriteLine("\n                   Muscle Builder                    ");
            Console.WriteLine("\n       Black, Asian & other minority ethnic groups   ");
            Console.WriteLine("\n------------------------------------------------------\n");
        }
    }
}
