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

            Grades actualGrade = converter.ConvertToGrade(0);

            //Assert

            Assert.AreEqual(expectedGrade, actualgrade);
        }
    }
}
