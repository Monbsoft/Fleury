using Monbsoft.Fleury.Application.Interfaces;
using System.Net.Http.Headers;

namespace Monbsoft.Fleury.Application.Domain;

public class Subtraction : Calculation, IOperation
{
    public Subtraction(decimal operand1, decimal operand2)
        : base(Operator.Minus, operand1, operand2)
    {
    }

    public decimal Result => Operand1 - Operand2;

    public static Subtraction Create(decimal operand1, decimal operand2)
    {
        return new Subtraction(operand1, operand2);
    }
    public bool Check(decimal response)
    {
        return Result.Equals(response);
    }
    public override string ToString()
    {
        return $"(- {Operand1} {Operand2})";
    }
}

