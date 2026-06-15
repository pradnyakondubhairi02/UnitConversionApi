using UnitConversionApi.Models;

namespace UnitConversionApi.Interfaces
{
    public interface IConversionService
    {
        ConversionResponse Convert(ConversionRequest request);
    }
}
