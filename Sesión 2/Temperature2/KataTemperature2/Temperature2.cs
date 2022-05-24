using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTemperature2
{
    public class Temperature2 : Attribute
    {
        double temperatura;
        string escala;

        public Temperature2(double temperatura, string escala)
        {
            this.temperatura = temperatura;
            this.escala = escala;
        }

        public double ToCelsius(double x)
        {
            Temperature2 temp = new Temperature2(temperatura, escala);
            if (temp.escala == "Fahrenheit")
                return (x - 32) / 1.8;
            else if (temp.escala == "Kelvin")
                return x -= 273.15;
            else
                return 0;
        }
        public double ToFahrenheit(double x)
        {
            Temperature2 temp = new Temperature2(temperatura, escala);
            if (temp.escala == "Celsius")
                return x * 1.8 + 32;
            else if (temp.escala == "Kelvin")
            {
                Temperature2 temp2 = new Temperature2(x, "Kelvin");
                double y = temp2.ToCelsius(x);
                Temperature2 temp3 = new Temperature2(y, "Celsius");
                return temp3.ToFahrenheit(y);
            }
            else
                return 0;
        }
        public double ToKelvin(double x)
        {
            Temperature2 temp = new Temperature2(temperatura, escala);
            if (temp.escala == "Celsius")
                return x += 273.15;
            else if (temp.escala == "Fahrenheit")
            {
                Temperature2 temp2 = new Temperature2(x, "Fahrenheit");
                double y = temp2.ToCelsius(x);
                Temperature2 temp3 = new Temperature2(y, "Celsius");
                return temp3.ToKelvin(y);
            }
            else
                return 0;
        }
        public string ToString(string x)
        {
            Temperature2 temp = new Temperature2(temperatura, escala);
            if (temp.escala == "Celsius")
                return temp.temperatura.ToString() + " ºC";
            else if (temp.escala == "Fahrenheit")
                return temp.temperatura.ToString() + " ºF";
            else if (temp.escala == "Kelvin")
                return temp.temperatura.ToString() + " K";
            else
                return " ";
        }

        public double Add(double temperature, string scale)
        {
            Temperature2 temp = new Temperature2(temperatura, escala);
            if (temp.escala == scale)
                return temp.temperatura + temperature;
            else
            {
                if (temp.escala == "Celsius" && scale != "Celsius")
                {
                    Temperature2 temp2 = new Temperature2(temperature, scale);
                    return temp.temperatura + temp2.ToCelsius(temperature);
                }
                else if (temp.escala == "Fahrenheit" && scale != "Fahrenheit")
                {
                    Temperature2 temp2 = new Temperature2(temperature, scale);
                    return temp.temperatura + temp2.ToFahrenheit(temperature);
                }
                else if (temp.escala == "Kelvin" && scale != "Kelvin")
                {
                    Temperature2 temp2 = new Temperature2(temperature, scale);
                    return temp.temperatura + temp2.ToKelvin(temperature);
                }
                else
                    return 0;
            }
        }
        public double Substract(double temperature, string scale)
        {
            Temperature2 temp = new Temperature2(temperatura, escala);
            if (temp.escala == scale)
                return temp.temperatura - temperature;
            else
            {
                if (temp.escala == "Celsius" && scale != "Celsius")
                {
                    Temperature2 temp2 = new Temperature2(temperature, scale);
                    return temp.temperatura - temp2.ToCelsius(temperature);
                }
                else if (temp.escala == "Fahrenheit" && scale != "Fahrenheit")
                {
                    Temperature2 temp2 = new Temperature2(temperature, scale);
                    return temp.temperatura - temp2.ToFahrenheit(temperature);
                }
                else if (temp.escala == "Kelvin" && scale != "Kelvin")
                {
                    Temperature2 temp2 = new Temperature2(temperature, scale);
                    return temp.temperatura - temp2.ToKelvin(temperature);
                }
                else
                    return 0;
            }
        }
        public double MultiplyBy(double temperature, string scale)
        {
            Temperature2 temp = new Temperature2(temperatura, escala);
            if (temp.escala == scale)
                return temp.temperatura * temperature;
            else
            {
                if (temp.escala == "Celsius" && scale != "Celsius")
                {
                    Temperature2 temp2 = new Temperature2(temperature, scale);
                    return temp.temperatura * temp2.ToCelsius(temperature);
                }
                else if (temp.escala == "Fahrenheit" && scale != "Fahrenheit")
                {
                    Temperature2 temp2 = new Temperature2(temperature, scale);
                    return temp.temperatura * temp2.ToFahrenheit(temperature);
                }
                else if (temp.escala == "Kelvin" && scale != "Kelvin")
                {
                    Temperature2 temp2 = new Temperature2(temperature, scale);
                    return temp.temperatura * temp2.ToKelvin(temperature);
                }
                else
                    return 0;
            }
        }
        public double DivideBy(double temperature, string scale)
        {
            Temperature2 temp = new Temperature2(temperatura, escala);
            if (temp.escala == scale)
                return temp.temperatura / temperature;
            else
            {
                if (temp.escala == "Celsius" && scale != "Celsius")
                {
                    Temperature2 temp2 = new Temperature2(temperature, scale);
                    return temp.temperatura / temp2.ToCelsius(temperature);
                }
                else if (temp.escala == "Fahrenheit" && scale != "Fahrenheit")
                {
                    Temperature2 temp2 = new Temperature2(temperature, scale);
                    return temp.temperatura / temp2.ToFahrenheit(temperature);
                }
                else if (temp.escala == "Kelvin" && scale != "Kelvin")
                {
                    Temperature2 temp2 = new Temperature2(temperature, scale);
                    return temp.temperatura / temp2.ToKelvin(temperature);
                }
                else
                    return 0;
            }
        }
    }
}
