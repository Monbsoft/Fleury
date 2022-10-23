namespace Fleury.UnitTests.Application;

public class MultiplicationTests
{
    [Fact]
    public void CalculateTest()
    {
        var multiplication = Multiplication.Create(2, 8);

        multiplication.Result.Should().Be(16);
    }
    [Fact]
    public void CreateTest()
    {
        var multiplication = Multiplication.Create(45, 12);

        multiplication.Operator.Should().Be(Operator.Multiply);
        multiplication.Operand1.Should().Be(45);
        multiplication.Operand2.Should().Be(12);
    }
    [Fact]
    public void ToStringTest()
    {
        var multiplication = Multiplication.Create(25, 5);

        var text = multiplication.ToString();

        text.Should().Be("(* 25 5)");
    }
}
