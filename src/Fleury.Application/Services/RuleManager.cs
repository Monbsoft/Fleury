using Monbsoft.Fleury.Application.Domain;
using Monbsoft.Fleury.Application.Interfaces;
using Monbsoft.Fleury.Application.Rules;

namespace Monbsoft.Fleury.Application.Services;

public class RuleManager : IRuleManager
{
    private readonly List<IRule> _rules;
    private readonly Random _random;

    public RuleManager()
    {
        _rules = new List<IRule>();
        _random = new Random();
    }

    public IReadOnlyCollection<IRule> GetRules() => _rules.AsReadOnly();

    /// <summary>
    /// Chooses a rule at random
    /// </summary>
    /// <returns>A calculation rule</returns>
    /// <exception cref="ArgumentNullException"></exception>
    public IRule Choose(GameContext context)
    {
        if (context == null) 
            throw new ArgumentNullException(nameof(context));

        if (_rules.Count == 1)
            return _rules.First();

        int index = _random.Next(0, _rules.Count);
        return _rules.ElementAt(index);

    }
    /// <summary>
    /// Generates rules
    /// </summary>
    /// <param name="context"></param>
    /// <exception cref="ArgumentNullException"></exception>
    public void Generate(GameContext context)
    {
        if (context == null) throw new ArgumentNullException(nameof(context));

        _rules.Clear();
        _rules.Add(new SimpleRule());
    }
}
