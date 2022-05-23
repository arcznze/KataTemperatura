using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit.Sdk;
using Kata_Temperatura;
using System;

namespace KataTemperatureTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ToKelvinTest()
        {
            double x = 53;
            string y = "Celsius";
            double expected = 326.15;

            Temperature test = new Temperature(x, y);
            double actual = test.ToKelvin(x);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToKelvinTest02()
        {
            double x = 53;
            string y = "Fahrenheit";
            double expected = 284.82;

            Temperature test = new Temperature(x, y);
            double t = test.ToKelvin(x);
            double actual = Math.Round(t, 2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToCelsiusTest()
        {
            double x = 426;
            string y = "Fahrenheit";
            double expected = 152.85;

            Temperature test = new Temperature(x, y);
            double t = test.ToCelsius(x);
            double actual = Math.Round(t, 2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToCelsiusTest02()
        {
            double x = 426;
            string y = "Fahrenheit";
            double expected = 218.89;

            Temperature test = new Temperature(x, y);
            double t = test.ToCelsius(x);
            double actual = Math.Round(t, 2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToFahrenheitTest()
        {
            double x = 111;
            string y = "Fahrenheit";
            double expected = 231.8;

            Temperature test = new Temperature(x, y);
            double t = test.ToFahrenheit(x);
            double actual = Math.Round(t, 2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToFahrenheitTest02()
        {
            double x = 111;
            string y = "Celsius";
            double expected = 231.8;

            Temperature test = new Temperature(x, y);
            double t = test.ToFahrenheit(x);
            double actual = Math.Round(t, 2);

            Assert.AreEqual(expected, actual);
        }
    }
}