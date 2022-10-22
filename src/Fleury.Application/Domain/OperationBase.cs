using Monbsoft.Fleury.Application.Interfaces;

namespace Monbsoft.Fleury.Application.Domain;

public abstract class OperationBase : IOperation
{
    public OperationBase(Calculation calculation)
    {
        Calculation = calculation ?? throw new ArgumentNullException(nameof(calculation));
    }

    public Calculation Calculation { get; }
    public abstract double Result { get; }

    public bool Check(double value)
    {
        return Result.Equals(value);
    }
}

