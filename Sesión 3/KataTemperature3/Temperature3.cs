using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTemperature3
{
    public class Temperature3 : Attribute
    {
        double temperature;
        string scale;

        public Temperature3(double temperature, string scale)
        {
            this.temperature = temperature;
            this.scale = scale;
        }

        public double ToCelsius(double x)
        {
            Temperature3 temp = new Temperature3(temperature, scale);
            switch (temp.scale)
            {
                case "Kelvin":
                    return x - 273.15;
                case "Fahrenheit":
                    return (x - 32) / 1.8;
                default:
                    return 0;
            }
        }
        public double ToFahreheit(double x)
        {
            Temperature3 temp = new Temperature3(temperature, scale);
            switch (temp.scale)
            {
                case "Kelvin":
                    return (x - 273.15) * 1.8 + 32;
                case "Celsius":
                    return x * 1.8 + 32;
                default:
                    return 0;
            }
        }
        public double ToKelvin(double x)
        {
            Temperature3 temp = new Temperature3(temperature, scale);
            switch (temp.scale)
            {
                case "Fahrenheit":
                    return ((x - 32) / 1.8) + 273.15;
                case "Celsius":
                    return x + 273.15;
                default:
                    return 0;
            }
        }

        public string ToString(string x)
        {
            Temperature3 temp = new Temperature3(temperature, scale);
            switch (temp.scale)
            {
                case "Fahrenheit":
                    return temp.temperature.ToString() + " ºF";
                case "Celsius":
                    return temp.temperature.ToString() + " ºC";
                case "Kelvin":
                    return temp.temperature.ToString() + " K";
                default:
                    return "Ingresó una escala que no es válida.";
            }
        }

        public double Add(double a, string b)
        {
            Temperature3 temp = new Temperature3(temperature, scale);

            if (temp.scale == b)
                return temp.temperature + a;
            else
            {
                switch (temp.scale)
                {
                    case "Fahrenheit":
                        Temperature3 t = new Temperature3(a, b);
                        return temp.temperature + t.ToFahreheit(a);
                    case "Celsius":
                        t = new Temperature3(a, b);
                        return temp.temperature + t.ToCelsius(a);
                    case "Kelvin":
                        t = new Temperature3(a, b);
                        return temp.temperature + t.ToKelvin(a);
                    default:
                        return 0;
                }
            }
        }
        public double Substract(double a, string b)
        {
            Temperature3 temp = new Temperature3(temperature, scale);

            if (temp.scale == b)
                return temp.temperature - a;
            else
            {
                switch (temp.scale)
                {
                    case "Fahrenheit":
                        Temperature3 t = new Temperature3(a, b);
                        return temp.temperature - t.ToFahreheit(a);
                    case "Celsius":
                        t = new Temperature3(a, b);
                        return temp.temperature - t.ToCelsius(a);
                    case "Kelvin":
                        t = new Temperature3(a, b);
                        return temp.temperature - t.ToKelvin(a);
                    default:
                        return 0;
                }
            }
        }
        public double MultiplyBy(double a, string b)
        {
            Temperature3 temp = new Temperature3(temperature, scale);

            if (temp.scale == b)
                return temp.temperature * a;
            else
            {
                switch (temp.scale)
                {
                    case "Fahrenheit":
                        Temperature3 t = new Temperature3(a, b);
                        return temp.temperature * t.ToFahreheit(a);
                    case "Celsius":
                        t = new Temperature3(a, b);
                        return temp.temperature * t.ToCelsius(a);
                    case "Kelvin":
                        t = new Temperature3(a, b);
                        return temp.temperature * t.ToKelvin(a);
                    default:
                        return 0;
                }
            }
        }
        public double DivideBy(double a, string b)
        {
            Temperature3 temp = new Temperature3(temperature, scale);

            if (temp.scale == b)
                return temp.temperature / a;
            else
            {
                switch (temp.scale)
                {
                    case "Fahrenheit":
                        Temperature3 t = new Temperature3(a, b);
                        return temp.temperature / t.ToFahreheit(a);
                    case "Celsius":
                        t = new Temperature3(a, b);
                        return temp.temperature / t.ToCelsius(a);
                    case "Kelvin":
                        t = new Temperature3(a, b);
                        return temp.temperature / t.ToKelvin(a);
                    default:
                        return 0;
                }
            }
        }
    }
}
