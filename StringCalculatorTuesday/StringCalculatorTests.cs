
namespace StringCalculator;

public class StringCalculatorTests
{
    [Fact]
    public void EmptyStringReturnsZero()
    {
        var calculator = new StringCalculator();

        var result = calculator.Add("");

        Assert.Equal(0, result);
    }

    [Theory]
    [InlineData("1", 1)]
    [InlineData("2", 2)]
    [InlineData("118", 118)]
    public void SingleDigit(string numbers, int expected)
    {
        var calculator = new StringCalculator();

        var result = calculator.Add(numbers);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("1, 1")]
    [InlineData("2, 2")]
    [InlineData("118, 118")]
    public void SingleString(string numbers)
    {
        var calculator = new StringCalculator();

        String[] list = numbers.Split(',');

        var result = calculator.Add(list[0]);
        var expected = int.Parse(list[1]);

        Assert.Equal(expected, result);
    }
}
