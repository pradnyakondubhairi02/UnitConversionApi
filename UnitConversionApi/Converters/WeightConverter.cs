using UnitConversionApi.Interfaces;

namespace UnitConversionApi.Converters
{
    public class WeightConverter : IUnitConverter
    {
        public string Category => "Weight";
        private readonly Dictionary<string, double> _units =
    new(StringComparer.OrdinalIgnoreCase)
{
    { "Gram", 1 },
    { "Kilogram", 1000 },
    { "Pound", 453.59237 }
};

        public double Convert(double value, string fromUnit, string toUnit)
        {
            if(!_units.ContainsKey(fromUnit) || !_units.ContainsKey(toUnit))
            {
                throw new ArgumentException($"Unsupported unit: {fromUnit} or {toUnit}");

            }

            double valueInBase = value * _units[fromUnit];
            return valueInBase / _units[toUnit];

        }
    }
}
