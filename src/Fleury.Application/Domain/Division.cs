using Monbsoft.Fleury.Application.Interfaces;

namespace Monbsoft.Fleury.Application.Domain;

public class Division : Calculation, IOperation
{
    public Division(decimal operand1, decimal operand2)
        : base(Operator.Divide, operand1, operand2)
    {
    }

    public decimal Result => Operand1 / Operand2;

    public static Division Create(decimal operand1, decimal operand2)
    {
        return new Division(operand1, operand2);
    }
}