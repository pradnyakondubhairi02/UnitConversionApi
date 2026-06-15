using UnitConversionApi.Converters;

namespace UnitConversionApi.Tests;

public class TemperatureConverterTests
{
    private readonly TemperatureConverter _converter = new();

    [Fact]
    public void Celsius_To_Fahrenheit_Should_Return_Correct_Value()
    {
        double result = _converter.Convert(100,"Celsius", "Fahrenheit");

        Assert.Equal(212, result);
    }

    [Fact]
    public void Fahrenheit_To_Celsius_Should_Return_Correct_Value()
    {
        double result = _converter.Convert(32,"Fahrenheit", "Celsius");

        Assert.Equal(0, result);
    }

    [Fact]
    public void Celsius_To_Kelvin_Should_Return_Correct_Value()
    {
        double result = _converter.Convert(100,"Celsius", "Kelvin");

        Assert.Equal(373.15, result);
    }
}