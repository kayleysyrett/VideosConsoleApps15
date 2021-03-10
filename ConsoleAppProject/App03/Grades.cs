using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.Text;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App03
{
    /// <summary>
    /// Grade A is First Class   : 70 - 100
    /// Grade B is Upper Second  : 60 - 69
    /// Grade C is Lower Second  : 50 - 59
    /// Grade D is Third Class   : 40 - 49
    /// Grade F is Fail          :  0 - 39
    /// </summary>
    public enum Grades
    {
        [Description("Fail")]
        F, 
        [Description("Third Class")]
        D, 
        [Description("Lower Second")]
        C, 
        [Description("Upper Second")]
        B, 
        [Description("First Class")]
        A
    }

    public class StudentGrades
    {
        public string[] Students { get; set; }
        public int[] Marks { get; set; }
        public int[] GradeProfile { get; set; }
        public double[] Mean { get; set; }
        public int[] Minimum { get; set; }
        public int[] Maximum { get; set; }
    }

    public void Run()
    {

    }


}
