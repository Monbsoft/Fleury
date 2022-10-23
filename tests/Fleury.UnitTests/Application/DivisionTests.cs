using FluentAssertions;

namespace Fleury.UnitTests.Application;

public class DivisionTests
{
    [Fact]
    public void CalculateTest()
    {
        var division = Division.Create(16, 4);

        division.Result.Should().Be(4);
    }
    [Fact]
    public void CreateTest()
    {
        var division = Division.Create(24, 6);

        division.Operator.Should().Be(Operator.Divide);
        division.Operand1.Should().Be(24);
        division.Operand2.Should().Be(6);
    }

    [Fact]
    public void ToStringTest()
    {
        var text = Division.Create(100, 10).ToString();

        text.Should().Be("(/ 100 10)");
    }
}
