using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App03;

namespace ConsoleApp.Tests
{
    [TestClass]
    public class TestStudentGrades
    {
        private readonly StudentGrades converter = newStudentGrades(); 

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
    }
}
