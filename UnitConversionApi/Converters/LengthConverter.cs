using UnitConversionApi.Interfaces;

namespace UnitConversionApi.Converters
{
    public class LengthConverter : IUnitConverter
    {
        public string Category => "Length";
        private readonly Dictionary<string, double> _units = new(StringComparer.OrdinalIgnoreCase)
{
    { "Meter", 1 },
    { "Kilometer", 1000 },
    { "Foot", 0.3048 },
    { "Centimeter", 0.01 },
    { "Millimeter", 0.001 }
};

        public double Convert(double value, string fromUnit, string toUnit) 
        {
            if(!_units.ContainsKey(fromUnit) || !_units.ContainsKey(toUnit))
            {
                throw new ArgumentException($"Unsupported unit: {fromUnit} or {toUnit}");
            }

           
                double valueInMeters = value * _units[fromUnit];
                return valueInMeters / _units[toUnit];
            
        }
    }
}
