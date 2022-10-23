using Monbsoft.Fleury.Application.Interfaces;

namespace Monbsoft.Fleury.Application.Domain;


public class Addition : Calculation, IOperation
{
    public Addition(decimal operand1, decimal operand2)
        : base(Operator.Plus, operand1, operand2)
    {
    }

    public decimal Result => Operand1 + Operand2;

    public static Addition Create(decimal operand1, decimal operand2)
    {
        return new Addition(operand1, operand2);
    }
    public override string ToString()
    {
        return $"(+ {Operand1} {Operand2})";
    }
}
