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
    }

    /// <summary>
    /// Input a mark between 0-100 for each student 
    /// and store it in the Marks array
    /// </summary>
    public void InputMarks()
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// List all the students and display their
    /// name and current mark
    /// </summary>
    public void OuputMarks()
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Convert a student mark to a grade
    /// from F (Fail) to A (First Class)
    /// </summary>
    public Grade ConvertToGrade(int mark)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Calculate and display the minimum, maximum
    /// and mean mark for all the students. 
    /// </summary>
    public void CalculateStats()
    {
        throw new NotImplementedException();
    }
}

