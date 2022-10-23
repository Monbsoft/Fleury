namespace Fleury.UnitTests.Application;

public class AdditionTests
{   
    [Fact]
    public void CalculateTest()
    {
        var addition = Addition.Create(65, 21);

        addition.Result.Should().Be(86);
    }
    [Fact]
    public void CreateTest()
    {
        var addition = Addition.Create(12, 14);

        addition.Operator.Should().Be(Operator.Plus);
        addition.Operand1.Should().Be(12);
        addition.Operand2.Should().Be(14);
    }
    [Fact]
    public void EqualsTest()
    {
        var addition1 = Addition.Create(21, 15);
        var addition2 = Addition.Create(21, 15);

        addition1.Should().Be(addition2);
    }    
    [Fact]
    public void ToStringTest()
    {
        var text = Addition.Create(54, 31).ToString();

        text.Should().Be("(+ 54 31)");
    }


}
