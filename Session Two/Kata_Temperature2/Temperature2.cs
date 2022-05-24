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

		public double Celsius(double x)
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
    }
}
