﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App01;
using System;

namespace ConsoleApp.Tests
{
    [TestClass]
    public class TestDistanceConverter
    {
        [TestMethod]
        public void TestMilesToFeet()
        {
            DistanceConverter converter = new DistanceConverter()
            
            converter.FromUnit = DistanceConverter.MILES;
            converter.ToUnit = DistanceConverter.FEET;

            converter.FromDistance = 1.0;
            converter.ConvertDistance();

            double expectedDistance = 5280;

            Assert.AreEqual(expectedDistance, converter.ToDistance);
                      
        }
    }
}
