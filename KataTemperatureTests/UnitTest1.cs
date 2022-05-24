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

        [TestMethod]
        public void ToStringTest()
        {
            double x = 111;
            string y = "Celsius";
            string expected = "231.8 ºF";

            Temperature test = new Temperature(x, y);
            double t = test.ToFahrenheit(x);
            double a = Math.Round(t, 2);
            test = new Temperature(a, "Fahrenheit");
            string actual = test.ToStringTempo(a.ToString());

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddTest()
        {
            double x = 266;
            string y = "Kelvin";
            double a = 49;
            string b = "Fahrenheit";
            double expected = 548.59;

            Temperature test = new Temperature(x, y);

            double c = test.Add(a, b);
            double actual = Math.Round(c, 2);

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void SubstractTest()
        {
            double x = 78;
            string y = "Fahrenheit";
            double a = 37;
            string b = "Celsius";
            double expected = 20.6;

            Temperature test = new Temperature(x, y);

            double c = test.Substract(a, b);
            double actual = Math.Round(c, 2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MultiplyByTest()
        {
            double x = 0;
            string y = "Kelvin";
            double a = 758;
            string b = "";
            double expected = 125.56;

            Temperature test = new Temperature(x, y);

            double c = test.MultiplyBy(a, b);
            double actual = Math.Round(c, 2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MultiplyByTest01()
        {
            double x = 50;
            string y = "Kelvin";
            double a = 758;
            string b = "Celsius";
            double expected = 51557.5;

            Temperature test = new Temperature(x, y);

            double c = test.MultiplyBy(a, b);
            double actual = Math.Round(c, 2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DivideByTest()
        {
            double x = 766;
            string y = "Fahrenheit";
            double a = 819;
            string b = "Kelvin";
            double expected = 76;

            Temperature test = new Temperature(x, y);

            double c = test.DivideBy(a, b);
            double actual = Math.Round(c, 2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DivideByTest02()
        {
            double x = 766;
            string y = "Kelvin";
            double a = 819;
            string b = "Kelvin";
            double expected = 0.94;

            Temperature test = new Temperature(x, y);

            double c = test.DivideBy(a, b);
            double actual = Math.Round(c, 2);

            Assert.AreEqual(expected, actual);
        }
    }
}