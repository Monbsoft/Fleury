using Monbsoft.Fleury.Application.Domain;
using Monbsoft.Fleury.Application.Interfaces;

namespace Monbsoft.Fleury.Application.Services;

public class Generator : IGenerator
{
    private readonly IRuleManager _ruleManager;

    public Generator(IRuleManager ruleManager)
    {
        _ruleManager = ruleManager;
    }

    /// <summary>
    /// Geneates operations by applying the rules.
    /// </summary>
    /// <returns></returns>
    public List<IOperation> GenerateOperations(GameContext context)
    {
        if (context == null) throw new ArgumentNullException(nameof(context));

        var operations = new List<IOperation>();
        _ruleManager.Generate(context);
        var rule = _ruleManager.Choose(context);

        for (int i = 0; i < 10; i++)
        {
            operations.Add(rule.Generate(context));
        }

        return operations;
    }

}