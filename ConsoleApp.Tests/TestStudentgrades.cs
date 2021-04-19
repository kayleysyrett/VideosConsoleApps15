using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App03;

namespace ConsoleApp.Tests
{
    [TestClass]
    public class TestStudentGrades
    {
        private readonly StudentGrades converter = newStudentGrades();

        private int[] testMarks;

        [TestMethod]
        public void TestConvert0ToGradeF()
        {
            // Arrange
            
            Grades expectedGrade = Grades.F

            //Act

            Grades actualGrade = converter.ConvertToGrade(0);

            //Assert

            Assert.AreEqual(expectedGrade, actualgrade);
        }
        [TestMethod]
        public void TestConvert39ToGradeA()
        {
            // Arrange

            Grades expectedGrade = Grades.A

            //Act

            Grades actualGrade = converter.ConvertToGrade(39);

            //Assert

            Assert.AreEqual(expectedGrade, actualgrade);
        }
        
        [TestMethod]
        public void TestCalculateMean()
        {
            converter.Marks = testMarks;
            double expectedMean = 55.0;
            converter.CalculateStats();

            Assert.AreEqual(expectedMean, TestStudentGrades.Mean);
        }

        public void TestCalculateMin()
        {
            //Arrange
            TestStudentGrades.Marks = StatsMarks;
            int expectedMin = 10;

            //Act
            TestStudentGrades.CalculateStats();

            //Assert
            Assert.AreEqual(expectedMin, TestStudentGrades.Minimum);
        }

        [TestClass]
        public class StudentGradesTest
        {
            private readonly StudentGradesTest
                studentGrades = new StudentGrades();

            private readonly int[] StatsMarks = new int[]
            {
                10, 20, 30, 40, 50, 60, 70, 80, 90, 100
            };
        }

        [TestMethod]
        public void TestGradeProfile()
        {
            //Arrange 
            StudentGrades.Marks = StatsMarks;
            bool expectedProfile = false;

            //Act
            StudentGrades.CalculateGradeProfile();

            expectedProfile = ((StudentGradesTest.GradeProfile[0] == 3) &&
                               (StudentGradesTest.GradeProfile[1] == 1) &&
                               (StudentGradesTest.GradeProfile[2] == 1) &&
                               (StudentGradesTest.GradeProfile[3] == 1) &&
                               (StudentGradesTest.GradeProfile[4] == 4));

            //Assert
            Assert.IsTrue(expectedProfile);
        }
    }
}
