using UnitConversionApi.Interfaces;

namespace UnitConversionApi.Converters
{
    public class TemperatureConverter :IUnitConverter
    {
        public string Category => "Temperature";
        private readonly Dictionary<string, Func<double, double>> _toCelsius =
        new(StringComparer.OrdinalIgnoreCase)
        {
            { "Celsius", value => value },
            { "Fahrenheit", value => (value - 32) * 5 / 9 },
            { "Kelvin", value => value - 273.15 }
        };

        private readonly Dictionary<string, Func<double, double>> _fromCelsius =
        new(StringComparer.OrdinalIgnoreCase)
        {
            { "Celsius", value => value },
            { "Fahrenheit", value => (value * 9 / 5) + 32 },
            { "Kelvin", value => value + 273.15 }
        };

        public double Convert(double value, string fromUnit, string toUnit)
        {
            if(!_fromCelsius.ContainsKey(fromUnit) || !_toCelsius.ContainsKey(toUnit))
            {
                throw new ArgumentException($"Unsupported unit: {fromUnit} or {toUnit}");
            }

           double celsiusValue= _toCelsius[fromUnit](value);
            return _fromCelsius[toUnit](celsiusValue);
        }
    }
}
