using DataPetriNetOnSmt.Abstractions;
using DataPetriNetOnSmt.DPNElements;
using DataPetriNetOnSmt.Enums;

namespace DataPetriNetOnSmt.Extensions
{
    public static class IEnumerableExtensions
    {
        public static IEnumerable<IConstraintExpression> GetVOVExpressionsWithBothVarsOverwrittenByTransitionFiring(this IEnumerable<IConstraintExpression> expressionsWithOverwrite)
        {
            return expressionsWithOverwrite
                .Where(x => x as ConstraintVOVExpression != null
                    && expressionsWithOverwrite
                        .Select(x => x.ConstraintVariable.Name)
                        .Contains((x as ConstraintVOVExpression).VariableToCompare.Name));
        }

        public static IEnumerable<IConstraintExpression> GetExpressionsOfType(this IEnumerable<IConstraintExpression> expressions, VariableType varType)
        {
            return expressions.Where(x => x.ConstraintVariable.VariableType == varType);
        }
    }
}
