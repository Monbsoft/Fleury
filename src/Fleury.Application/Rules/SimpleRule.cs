using Monbsoft.Fleury.Application.Domain;
using Monbsoft.Fleury.Application.Interfaces;

namespace Monbsoft.Fleury.Application.Rules;

public class SimpleRule : IRule
{
    private readonly Random random = new Random();

    /// <summary>
    /// Generates a calculation
    /// </summary>
    /// <returns>A calculation</returns>
    public OperationBase Generate(GameContext context)
    {
        double operand1 = Convert.ToDouble(random.Next(100));
        double operand2 = Convert.ToDouble(random.Next(100));


        return Addition.Create(operand1, operand2);
    }
}
