using System;
using MetricCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MetricCalculatorTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void InvalidPathShouldReturnResultObjectWithInvalidPathState()
        {
            string path = "Jaja c mamo";

            Result test = MetricCalculator.Program.CalculateConvertions(path);

            Assert.AreEqual(test.State, States.InvalidPath);

        }

        [TestMethod]
        public void Converting15KmToMeterShouldReturn15000M()
        {
            string path = @"C:\Users\perla\Desktop\INTEC Files\TestCase1.txt";
           
            Result app = MetricCalculator.Program.CalculateConvertions(path);

            string[] values = System.IO.File.ReadAllLines(path)[0].Split(',');

            string expected = "15000";
            string result = values[3];

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Converting8MToMiliMeterShouldReturn8000M()
        {
            string path = @"C:\Users\perla\Desktop\INTEC Files\TestCase2.txt";

            Result app = MetricCalculator.Program.CalculateConvertions(path);

            string[] values = System.IO.File.ReadAllLines(path)[0].Split(',');

            string expected = "8000";
            string result = values[3];

            Assert.AreEqual(expected, result);
            
        }

        [TestMethod]
        public void Converting300KMTokilometersShouldReturnTheSame()
        {
            string path = @"C:\Users\perla\Desktop\INTEC Files\TestCase3.txt";

            Result app = MetricCalculator.Program.CalculateConvertions(path);

            string[] values = System.IO.File.ReadAllLines(path)[0].Split(',');

            string expected = "300";
            string result = values[3];

            Assert.AreEqual(expected, result);
            
        }
    }
}
