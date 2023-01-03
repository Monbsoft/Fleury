using Fleury.Application.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fleury.Application.Interfaces;

public interface IOperation
{
    public decimal Operand1 { get; }
    public decimal Operand2 { get; }
    public Operator Operator { get; }
    public decimal Result { get; }
    bool Check(decimal response);
}