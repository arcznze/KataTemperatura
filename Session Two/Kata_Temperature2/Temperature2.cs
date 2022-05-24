using System;

public class Temperature2
{
	public Temperature2()
	{
        /*
        Add(other : Temperature) : Temperature //Same scale as subject
    Substract(other : Temperature) : Temperature //Same scale as subject
    MultiplyBy(other : Temperature) : Temperature //Same scale as subject
    DivideBy(other : Temperature) : Temperature //Same scale as subject
    Scale : TemperatureScale
    ToFahrenheit() : Temperature
    ToKelvin() : ...
    ToString() :
        */
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
    }
}
