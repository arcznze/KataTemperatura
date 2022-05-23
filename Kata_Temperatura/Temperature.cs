using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata_Temperatura
{

    /*
    Add(other : Temperature) : Temperature //Same scale as subject
    Substract(other : Temperature) : Temperature //Same scale as subject
    MultiplyBy(other : Temperature) : Temperature //Same scale as subject
    DivideBy(other : Temperature) : Temperature //Same scale as subject
    ToString() 
    */


    internal class Temperature : Attribute
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
        public string ToString(string x)
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

    }
}
