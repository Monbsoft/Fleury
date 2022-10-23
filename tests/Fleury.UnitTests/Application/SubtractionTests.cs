namespace Fleury.UnitTests.Application;

public class SubtractionTests
{
    [Fact]
    public void CalculateTest()
    {
        var subtraction = Subtraction.Create(2, 8);

        subtraction.Result.Should().Be(-6);
    }
    [Fact]
    public void CreateTest()
    {
        var subtraction = Subtraction.Create(37, 2);

        subtraction.Operator.Should().Be(Operator.Minus);
        subtraction.Operand1.Should().Be(37);
        subtraction.Operand2.Should().Be(2);
    }
    [Fact]
    public void ToStringTest()
    {
        var subtraction = Subtraction.Create(16, 3);

        var text = subtraction.ToString();

        text.Should().Be("(- 16 3)");
    }
}
