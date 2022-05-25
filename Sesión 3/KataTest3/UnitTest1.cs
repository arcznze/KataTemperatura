using KataTemperature3;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Xunit.Sdk;

namespace KataTest3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestKelvinPassed()
        {
            double x = 54;
            string y = "Celsius";
            double expected = 327.15;

            Temperature3 test = new Temperature3(x, y);
            double t = test.ToKelvin(x);
            double actual = Math.Round(t, 2);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestKelvinFailed()
        {
            double x = 112;
            string y = "Fahrenheit";
            double expected = 856.15;

            Temperature3 test = new Temperature3(x, y);
            double t = test.ToKelvin(x);
            double actual = Math.Round(t, 2);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestCelsiusPassed()
        {
            double x = 250;
            string y = "Fahrenheit";
            double expected = 121.11;

            Temperature3 test = new Temperature3(x, y);
            double t = test.ToCelsius(x);
            double actual = Math.Round(t, 2);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestCelsiusFailed()
        {
            double x = 250;
            string y = "";
            double expected = 485.68;

            Temperature3 test = new Temperature3(x, y);
            double t = test.ToCelsius(x);
            double actual = Math.Round(t, 2);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestFahrenheitPassed()
        {
            double x = 780;
            string y = "";
            double expected = 0;

            Temperature3 test = new Temperature3(x, y);
            double t = test.ToFahreheit(x);
            double actual = Math.Round(t, 2);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestFahrenheitFailed()
        {
            double x = 780;
            string y = "Kelvin";
            double expected = 273.15;

            Temperature3 test = new Temperature3(x, y);
            double t = test.ToFahreheit(x);
            double actual = Math.Round(t, 2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestStringPassed()
        {
            double x = 37;
            string y = "Celsius";
            string expected = "37 ºC";

            Temperature3 test = new Temperature3(x, y);
            string actual = test.ToString(y);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestStringFailed()
        {
            double x = 780;
            string y = "";
            string expected = "273.15";

            Temperature3 test = new Temperature3(x, y);
            string actual = test.ToString(y);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestAddPassed()
        {
            double x = 37;
            string y = "Celsius";
            double expected = 47.56;

            Temperature3 test = new Temperature3(x, y);
            double t = test.Add(51, "Fahrenheit");
            double actual = Math.Round(t, 2);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestAddPassed2()
        {
            double x = 37;
            string y = "Celsius";
            double expected = 88;

            Temperature3 test = new Temperature3(x, y);
            double t = test.Add(51, "Celsius");
            double actual = Math.Round(t, 2);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestAddFailed()
        {
            double x = 457;
            string y = "Kelvin";
            double expected = 945;

            Temperature3 test = new Temperature3(x, y);
            double t = test.Add(115, "Fahrenheit");
            double actual = Math.Round(t, 2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestSubstractPassed()
        {
            double x = 111;
            string y = "Celsius";
            double expected = 162.15;

            Temperature3 test = new Temperature3(x, y);
            double t = test.Substract(222, "Kelvin");
            double actual = Math.Round(t, 2);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestSubstractFailed()
        {
            double x = 111;
            string y = "Fahrenheit";
            double expected = 162.15;

            Temperature3 test = new Temperature3(x, y);
            double t = test.Substract(222, "Kelvin");
            double actual = Math.Round(t, 2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMultiplyByFailed()
        {
            double x = 4;
            string y = "Kelvin";
            double expected = 1085.92;

            Temperature3 test = new Temperature3(x, y);
            double t = test.MultiplyBy(29, "Fahrenheit");
            double actual = Math.Round(t, 2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDivideByPassed()
        {
            double x = 42;
            string y = "Fahrenheit";
            double expected = 0.5;

            Temperature3 test = new Temperature3(x, y);
            double t = test.DivideBy(29, "Celsius");
            double actual = Math.Round(t, 2);

            Assert.AreEqual(expected, actual);
        }
    }
}