using ConsoleAppProject;
using System;
using System.Collections.Generic;
using System.Text;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App03
{
    public class StudentGrades
    {
        //Constants (grade boundaries)
        public const int LowestMark = 0;
        public const int HighestMark = 100;

        public const int LowestGradeD = 40;
        public const int LowestGradeC = 50;
        public const int LowestGradeB = 60;
        public const int LowestGradeA = 70;

        //Properties
        public string[] Students { get; set; }
        public int[] Marks { get; set; }
        public int[] GradeProfile { get; set; }
        public double[] Mean { get; set; }
        public int[] Minimum { get; set; }
        public int[] Maximum { get; set; }

        //Attributes

        /// <summary>
        /// Class constructor called when an object is created and sets 
        /// up an array of students
        /// </summary>
        public StudentGrades()
        {
            Students = new string[]
            {
            "Kayley, April, Andrew, ",
            "Helen, Alex, Amy, Sophie,",
            "Robin, Ruby, Florence"
            };

            GradeProfile = new int[(int)Grades.A + 1];
            Marks = new int[Students.Length];
        }

        /// <summary>
        /// 
        /// </summary>
        public Grades ConvertToGrade(int mark)
        {
            if (mark >= LowestMark && 
                mark < LowestGradeD)
            {
                return Grades.F;
            }
            else return Grades.D;
        }

        public void CalculateStats()
        {
            Minimum = Marks[0];
            Maximum = Marks[0];

            double total = 0;

            foreach(int mark in Marks)
            {
                if (mark > Maximum) Maximum = mark;
                if (mark < Minimum) Minimum = mark;
                total = total + mark;
            }

            Mean = total / Marks.Length;
        }

        public void CalculateGradeProfile()
        {
            for(int i = 0; i < GradeProfile.Length; i++)
            {
                GradeProfile[i] = 0;
            }
            foreach(int mark in Marks)
            {
                Grades grade = ConvertToGrade(mark);
                GradeProfile[(int)grade]++;
            }

            OutputGradeProfile();
        }

        private void OutputGradeProfile()
        {
            Grades grade = Grade.X;
            Console.WriteLine();

            foreach(int count in GradeProfile)
            {
                int percentage = count * 100 / Marks.Length;
                Console.WriteLine($"Grade {grade} {percentage}% Count {count}");
                grade++;
            }
            Console.WriteLine();
        }
    }

    internal class Grade
    {
    }
}

