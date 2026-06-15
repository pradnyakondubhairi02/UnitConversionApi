using UnitConversionApi.Models;
using UnitConversionApi.Interfaces;
using UnitConversionApi.Converters;

namespace UnitConversionApi.Services;

public class ConversionService : IConversionService
{
    private readonly IEnumerable<IUnitConverter> _converters;

    public ConversionService(IEnumerable<IUnitConverter>conveters)
    {
        _converters = conveters;
    }

    public ConversionResponse Convert(ConversionRequest request)
    {
        var converter = _converters.FirstOrDefault(c => c.Category.Equals(request.Category, StringComparison.OrdinalIgnoreCase));

        if (converter == null)
        {
            throw new NotSupportedException(
                $"Conversion category '{request.Category}' is not supported.");
        }

        var convertedValue = converter.Convert(request.Value, request.FromUnit, request.ToUnit);
        return new ConversionResponse
        {
            Category = request.Category,
            FromUnit = request.FromUnit,
            ToUnit = request.ToUnit,
            OriginalValue = request.Value,
            ConvertedValue = convertedValue
        };
    }
}
