using ConsoleAppProject;
using System;
using System.Collections.Generic;
using System.Text;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App03
{
    public class StudentGrades
    {
        public string[] Students { get; set; }
        public int[] Marks { get; set; }
        public int[] GradeProfile { get; set; }
        public double[] Mean { get; set; }
        public int[] Minimum { get; set; }
        public int[] Maximum { get; set; }

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
            throw new NotImplementedException();
        }

        public void CalculateStats()
        {
            throw new NotImplementedException();
        }

        public void CalculateGradeProfile()
        {
            throw new NotImplementedException();
        }
    }
}

