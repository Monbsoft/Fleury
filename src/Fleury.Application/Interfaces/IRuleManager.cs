using Monbsoft.Fleury.Application.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monbsoft.Fleury.Application.Interfaces;

public interface IRuleManager
{
    IRule Choosee(GameContext context);
    void Generate(GameContext context);
}
