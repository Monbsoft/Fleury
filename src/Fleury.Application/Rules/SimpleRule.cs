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
    public IOperation Generate(GameContext context)
    {
        decimal operand1 = Convert.ToDecimal(random.Next(100));
        decimal operand2 = Convert.ToDecimal(random.Next(100));


        return Addition.Create(operand1, operand2);
    }
}
