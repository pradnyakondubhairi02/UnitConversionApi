using UnitConversionApi.Converters;

namespace UnitConversionApi.Tests;

public class WeightConverterTests
{
    private readonly WeightConverter _converter = new();

    [Fact]
    public void Kilogram_To_Pound_Should_Return_Correct_Value()
    {
        double result = _converter.Convert(10,"Kilogram", "Pound");

        Assert.Equal(22.0462, result, 4);
    }

    [Fact]
    public void Gram_To_Kilogram_Should_Return_Correct_Value()
    {
        double result = _converter.Convert(1000,"Gram", "Kilogram");

        Assert.Equal(1, result);
    }
}