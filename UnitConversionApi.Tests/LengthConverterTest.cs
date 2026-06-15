using UnitConversionApi.Converters;

namespace UnitConversionApi.Tests;

public class LengthConverterTests
{
    private readonly LengthConverter _converter = new();

    [Fact]
    public void Meter_To_Foot_Should_Return_Correct_Value()
    {
        // Arrange
        double value = 10;

        // Act
        double result = _converter.Convert(value,"Meter", "Foot");

        // Assert
        Assert.Equal(32.8084, result, 4);
    }

    [Fact]
    public void Kilometer_To_Meter_Should_Return_Correct_Value()
    {
        double result = _converter.Convert(5,"Kilometer", "Meter");

        Assert.Equal(5000, result);
    }
}