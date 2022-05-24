using System;

public class Temperature2
{
	public Temperature2()
	{
		double temperature;
		string scale;

		public Temperature2(double temperature, string scale)
        {
			this.temperature = temperature;
			this.scale = scale;
        }

		public double ToCelsius(double x)
        {
            Temperature2 temp = new Temperature2(temperature, scale);
            switch (temp.scale)
            {
                case temp.scale == "Fahrenheit":
                    x = (x - 32) / 1.8;
                    return x;
                case temp.scale == "Kelvin":
                    x -= 273.15;
                    return x;
                default:
                    return 0;
            }
        }
        public double ToFahrenheit(double x)
        {
            Temperature2 temp = new Temperature2(temperature, scale);
            switch (temp.scale)
            {
                case temp.scale == "Celsius":
                    x *= 1.8 + 32;
                    return x;
                case temp.scale == "Kelvin":
                    x = (x - 273.15) * 1.8 + 32;
                    return x;
                default:
                    return 0;
            }
        }
        public double ToKelvin(double x)
        {
            Temperature2 temp = new Temperature2(temperature, scale);
            switch (temp.scale)
            {
                case temp.scale == "Celsius":
                    x += 273.15;
                    return x;
                case temp.scale == "Fahrenheit":
                    x = (x - 32) * (5 / 9) + 273;
                    return x;
                default:
                    return 0;
            }
        }

        public string ToStringText(string x)
        {
            Temperature2 temp = new Temperature2(temperature, scale);
            switch (temp.scale)
            {
                case temp.scale == "Celsius":
                    return temp.temperature.ToString() + " ºC";
                case temp.scale == "Kelvin":
                    return temp.temperature.ToString() + " K";
                case temp.scale == "Fahrenheit":
                    return temp.temperature.ToString() + " ºF";
                default:
                    return "";
            }
        }

        public double Add(double a, string b)
        {
            Temperature2 temp = new Temperature2(temperature, scale);
            switch (temp.scale)
            {
                case temp.scale == b:
                    return temp.temperature + a;
                case temp.scale == "Celsius" && b != "Celsius":
                    Temperature2 x = new Temperature2(a, b);
                    double y = x.ToCelsius(a);
                    return temp.temperature + y;
                case temp.scale == "Fahrenheit" && b != "Fahrenheit":
                    Temperature2 x = new Temperature2(a, b);
                    double y = x.ToFahrenheit(a);
                    return temp.temperature + y;
                case temp.scale == "Kelvin" && b != "Kelvin":
                    Temperature2 x = new Temperature2(a, b);
                    double y = x.ToKelvin(a);
                    return temp.temperature + y;
                default:
                    return 0;
            }
        }
        public double Substract(double a, string b)
        {
            Temperature2 temp = new Temperature2(temperature, scale);
            switch (temp.scale)
            {
                case temp.scale == b:
                    return temp.temperature - a;
                case temp.scale == "Celsius" && b != "Celsius":
                    Temperature2 x = new Temperature2(a, b);
                    double y = x.ToCelsius(a);
                    return temp.temperature - y;
                case temp.scale == "Fahrenheit" && b != "Fahrenheit":
                    Temperature2 x = new Temperature2(a, b);
                    double y = x.ToFahrenheit(a);
                    return temp.temperature - y;
                case temp.scale == "Kelvin" && b != "Kelvin":
                    Temperature2 x = new Temperature2(a, b);
                    double y = x.ToKelvin(a);
                    return temp.temperature - y;
                default:
                    return 0;
            }
        }
        public double MultiplyBy(double a, string b)
        {
            Temperature2 temp = new Temperature2(temperature, scale);
            switch (temp.scale)
            {
                case temp.scale == b:
                    return temp.temperature * a;
                case temp.scale == "Celsius" && b != "Celsius":
                    Temperature2 x = new Temperature2(a, b);
                    double y = x.ToCelsius(a);
                    return temp.temperature * y;
                case temp.scale == "Fahrenheit" && b != "Fahrenheit":
                    Temperature2 x = new Temperature2(a, b);
                    double y = x.ToFahrenheit(a);
                    return temp.temperature * y;
                case temp.scale == "Kelvin" && b != "Kelvin":
                    Temperature2 x = new Temperature2(a, b);
                    double y = x.ToKelvin(a);
                    return temp.temperature * y;
                default:
                    return 0;
            }
        }
        public double DivideBy(double a, string b)
        {
            Temperature2 temp = new Temperature2(temperature, scale);
            switch (temp.scale)
            {
                case temp.scale == b:
                    return temp.temperature / a;
                case temp.scale == "Celsius" && b != "Celsius":
                    Temperature2 x = new Temperature2(a, b);
                    double y = x.ToCelsius(a);
                    return temp.temperature / y;
                case temp.scale == "Fahrenheit" && b != "Fahrenheit":
                    Temperature2 x = new Temperature2(a, b);
                    double y = x.ToFahrenheit(a);
                    return temp.temperature / y;
                case temp.scale == "Kelvin" && b != "Kelvin":
                    Temperature2 x = new Temperature2(a, b);
                    double y = x.ToKelvin(a);
                    return temp.temperature / y;
                default:
                    return 0;
            }
        }
    }
}
