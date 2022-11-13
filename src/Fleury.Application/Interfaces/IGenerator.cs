using Monbsoft.Fleury.Application.Domain;

namespace Monbsoft.Fleury.Application.Interfaces;

public interface IGenerator
{
    List<IOperation> GenerateOperations(GameContext context);
}