namespace Monbsoft.Fleury.Application.Domain;

public class Calculation
{
    public Calculation(Operator @operator, decimal operand1, decimal operand2)
    {
        Operator = @operator;
        Operand1 = operand1;
        Operand2 = operand2;
    }

    public Calculation(Calculation calculation)
    {
        Operator = calculation.Operator;
        Operand1 = calculation.Operand1;
        Operand2 = calculation.Operand2;
    }

    public decimal Operand1 { get; }
    public decimal Operand2 { get; }
    public Operator Operator { get; }

    public override bool Equals(object? obj)
    {
        var other = obj as Calculation;

        if (ReferenceEquals(other, null))
            return false;

        if (ReferenceEquals(other, this))
            return true;

        return other.Operator == Operator && other.Operand1 == Operand1 && other.Operand2 == Operand2;
    }

    public override int GetHashCode()
    {
        return Operator.GetHashCode() ^ Operand1.GetHashCode() ^ Operand2.GetHashCode();
    }
}
