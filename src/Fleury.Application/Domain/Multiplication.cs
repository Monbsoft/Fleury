using Monbsoft.Fleury.Application.Interfaces;

namespace Monbsoft.Fleury.Application.Domain;

public class Multiplication : Calculation, IOperation
{
    public Multiplication(decimal operand1, decimal operand2)
        : base(Operator.Multiply, operand1, operand2)
    {

    }

    public decimal Result => Operand1 * Operand2;

    public static Multiplication Create(decimal operand1, decimal operand2)
    {
        return new Multiplication(operand1, operand2);
    }
    public bool Check(decimal response)
    {
        return Result.Equals(response);
    }
    public override string ToString()
    {
        return $"(* {Operand1} {Operand2})";
    }
}
