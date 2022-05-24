using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata_Temperatura
{
    public class Temperature : Attribute
    {
        double temperature;
        string scale;

        public Temperature(double temperature, string scale)
        {
            this.temperature = temperature;
            this.scale = scale;
        }

        public double ToKelvin(double x)
        {
            Temperature tempo = new Temperature(temperature, scale);

            if (tempo.scale == "Celsius")
            {
                x += 273.15;
                return x;
            }
            else if (tempo.scale == "Fahrenheit")
            {
                x = ((x - 32) / 1.8) + 273.15;
                return x;
            }
            else
                return 0;
        }
        public double ToCelsius(double x)
        {
            Temperature tempo = new Temperature(temperature, scale);
            if (tempo.scale == "Kelvin")
            {
                x -= 273.15;
                return x;
            }
            else if (tempo.scale == "Fahrenheit")
            {
                x = (x - 32) / 1.8;
                return x;
            }
            else
                return 0;
        }
        public double ToFahrenheit(double x)
        {
            Temperature tempo = new Temperature(temperature, scale);
            if (tempo.scale == "Celsius")
            {
                x = (x * 1.8) + 32;
                return x;
            }
            else if (tempo.scale == "Kelvin")
            {
                x = (x - 273.15) * 1.8 + 32;
                return x;
            }
            else
                return 0;
        }
        public string ToStringTempo(string x)
        {
            Temperature tempo = new Temperature(temperature, scale);
            if (tempo.scale == "Kelvin")
                return tempo.temperature.ToString() + " K";
            else if (tempo.scale == "Celsius")
            {
                return tempo.temperature.ToString() + " ºC";
            }
            else if (tempo.scale == "Fahrenheit")
            {
                return tempo.temperature.ToString() + " ºF";
            }
            else
                return "";
        }

        public double Add(double x, string y)
        {
            Temperature tempo = new Temperature(temperature, scale);
            if (y == tempo.scale)
                return tempo.temperature + x;
            else
            {
                if (tempo.scale == "Kelvin" && y != "Kelvin")
                {
                    Temperature t = new Temperature(x, y);
                    return tempo.temperature + t.ToKelvin(x);
                }
                else if (tempo.scale == "Celsius" && y != "Celsius")
                {
                    Temperature t = new Temperature(x, y);
                    return tempo.temperature + t.ToCelsius(x);
                }
                else if (tempo.scale == "Fahrenheit" && y != "Fahrenheit")
                {
                    Temperature t = new Temperature(x, y);
                    return tempo.temperature + t.ToFahrenheit(x);
                }
                else
                    return 0;
            }

        }
        public double Substract(double x, string y)
        {
            Temperature tempo = new Temperature(temperature, scale);
            if (y == tempo.scale)
                return tempo.temperature - x;
            else
            {
                if (tempo.scale == "Kelvin" && y != "Kelvin")
                {
                    Temperature t = new Temperature(x, y);
                    return tempo.temperature - t.ToKelvin(x);
                }
                else if (tempo.scale == "Celsius" && y != "Celsius")
                {
                    Temperature t = new Temperature(x, y);
                    return tempo.temperature - t.ToCelsius(x);
                }
                else if (tempo.scale == "Fahrenheit" && y != "Fahrenheit")
                {
                    Temperature t = new Temperature(x, y);
                    return tempo.temperature - t.ToFahrenheit(x);
                }
                else
                    return 0;
            }
        }
        public double MultiplyBy(double x, string y)
        {
            Temperature tempo = new Temperature(temperature, scale);
            if (y == tempo.scale)
                return tempo.temperature * x;
            else
            {
                if (tempo.scale == "Kelvin" && y != "Kelvin")
                {
                    Temperature t = new Temperature(x, y);
                    return tempo.temperature * t.ToKelvin(x);
                }
                else if (tempo.scale == "Celsius" && y != "Celsius")
                {
                    Temperature t = new Temperature(x, y);
                    return tempo.temperature * t.ToCelsius(x);
                }
                else if (tempo.scale == "Fahrenheit" && y != "Fahrenheit")
                {
                    Temperature t = new Temperature(x, y);
                    return tempo.temperature * t.ToFahrenheit(x);
                }
                else
                    return 0;
            }
        }
        public double DivideBy(double x, string y)
        {
            Temperature tempo = new Temperature(temperature, scale);
            if (tempo.scale == y)
                return tempo.temperature / x;
            else
            {
                if (tempo.scale == "Kelvin" && y != "Kelvin")
                {
                    Temperature t = new Temperature(x, y);
                    return tempo.temperature / t.ToKelvin(x);
                }
                else if (tempo.scale == "Celsius" && y != "Celsius")
                {
                    Temperature t = new Temperature(x, y);
                    return tempo.temperature / t.ToCelsius(x);
                }
                else if (tempo.scale == "Fahrenheit" && y != "Fahrenheit")
                {
                    Temperature t = new Temperature(x, y);
                    return tempo.temperature / t.ToFahrenheit(x);
                }
                else
                    return 0;
            }
        }
    }
}
