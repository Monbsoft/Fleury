using Monbsoft.Fleury.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monbsoft.Fleury.Application.Domain;

public class Multiplication : Calculation, IOperation
{
    public Multiplication(decimal operand1, decimal operand2)
        : base(Operator.Multiply, operand1, operand2)
    {

    }

    public decimal Result => Operand1 * Operand2;

    public static Multiplication Create(decimal operand1, decimal operand2)
    {
        return new Multiplication(operand1, operand2);
    }
    public override string ToString()
    {
        return $"(* {Operand1} {Operand2})";
    }
}
