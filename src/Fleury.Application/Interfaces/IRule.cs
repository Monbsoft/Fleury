using Monbsoft.Fleury.Application.Domain;

namespace Monbsoft.Fleury.Application.Interfaces;

public interface IRule
{
    OperationBase Generate(GameContext context);
}

