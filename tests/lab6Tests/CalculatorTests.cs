using Xunit;
using MyProject;

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
}
