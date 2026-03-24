using Xunit;

namespace lab6Project.tests;

public class CalculatorTests
{
    [Fact]
    public void Add_ShouldReturnCorrectSum()
    {
        var calc = new Calculator();

        var result = calc.Add(2, 3);

        Assert.Equal(5, result);
    }

    [Fact]
    public void Subtract_ShouldReturnCorrectSum()
    {
        var calc = new Calculator();

        var result = calc.Subtract(2, 3);

        Assert.Equal(-1, result);
    }

    [Fact]
    public void Multiply_ShouldReturnCorrectSum()
    {
        var calc = new Calculator();

        var result = calc.Multiply(2, 3);

        Assert.Equal(6, result);
    }

    [Fact]
    public void Divide_ShouldReturnCorrectResult()
    {
        var calc = new Calculator();

        var result = calc.Divide(10, 2);

        Assert.Equal(5, result);
    }

    [Fact]
    public void Divide_ByZeroShouldThrowException()
    {
        var calc = new Calculator();

        Assert.Throws<ArgumentException>(() => calc.Divide(10, 0));
    }

    [Theory]
    [InlineData(10, 5, 10)] // для a > b
    [InlineData(3, 8, 8)] // для b > a
    [InlineData(7, 7, 7)] // для a == b
    public void GetMax_ShouldReturnGreaterInt(int a, int b, int expected)
    {
        var calc = new Calculator();
        var result = calc.GetMax(a, b);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(10, 55, 10)] // для a < b
    [InlineData(34, 8, 8)] // для b < a
    [InlineData(7, 7, 7)] // для a == b
    public void GetMax_ShouldReturnLessrInt(int a, int b, int expected)
    {
        var calc = new Calculator();
        var result = calc.GetMin(a, b);
        Assert.Equal(expected, result);
    }
}
