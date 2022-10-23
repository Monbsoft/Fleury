using Monbsoft.Fleury.Application.Domain;

namespace Monbsoft.Fleury.Application.Interfaces;

public interface IRule
{
    IOperation Generate(GameContext context);
}

