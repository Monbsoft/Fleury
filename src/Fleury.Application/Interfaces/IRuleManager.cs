using Monbsoft.Fleury.Application.Domain;

namespace Monbsoft.Fleury.Application.Interfaces;

public interface IRuleManager
{
    IRule Choose(GameContext context);
    void Generate(GameContext context);
}
