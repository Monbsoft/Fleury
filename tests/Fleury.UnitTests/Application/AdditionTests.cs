using FluentAssertions;
using Monbsoft.Fleury.Application.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fleury.UnitTests.Application;

public class AdditionTests
{
    [Fact]
    public void CreateTest()
    {
        var addition = Addition.Create(12, 14);

        addition.Calculation.Operator.Should().Be(Operator.Plus);
        addition.Calculation.Operand1.Should().Be(12);
        addition.Calculation.Operand2.Should().Be(14);
    }
}
