using KataTemperature2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace KataTest2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void KelvinTest()
        {
            double expected = 506.48;

            Temperature2 test = new Temperature2(452, "Fahrenheit");
            double y = test.ToKelvin(452);
            double actual = Math.Round(y, 2);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void KelvinTest2()
        {
            double expected = 258.56;

            Temperature2 test = new Temperature2(452, "Celsius");
            double y = test.ToKelvin(452);
            double actual = Math.Round(y, 2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FahrenheitTest()
        {
            double expected = 904.73;

            Temperature2 test = new Temperature2(758, "Kelvin");
            double y = test.ToFahrenheit(758);
            double actual = Math.Round(y, 2);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FahrenheitTest2()
        {
            double expected = 459;

            Temperature2 test = new Temperature2(758, "");
            double y = test.ToFahrenheit(758);
            double actual = Math.Round(y, 2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CelsiusTest_StringTest()
        {
            string c = " ";
            string expected = "484.85 ºC";

            Temperature2 test = new Temperature2(758, "Kelvin");
            double y = test.ToCelsius(758);
            double t = Math.Round(y, 2);

            Temperature2 test2 = new Temperature2(t, "Celsius");
            string actual = test2.ToString(c);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddTest()
        {
            double expected = 1083.15;

            Temperature2 test = new Temperature2(758, "Kelvin");
            double y = test.Add(52, "Celsius");
            double actual = Math.Round(y, 2);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SubstractTest()
        {
            double expected = 4859;

            Temperature2 test = new Temperature2(758, "Fahrenheit");
            double y = test.Substract(52, "Kelvin");
            double actual = Math.Round(y, 2);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void MultiplyByTest()
        {
            double expected = 0;

            Temperature2 test = new Temperature2(758, "Fahrenheit");
            double y = test.MultiplyBy(52, "Kelvin");
            double actual = Math.Round(y, 2);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void DivideByTest()
        {
            double expected = 1.03;

            Temperature2 test = new Temperature2(221, "Fahrenheit");
            double y = test.DivideBy(102, "Celsius");
            double actual = Math.Round(y, 2);

            Assert.AreEqual(expected, actual);
        }
    }
}