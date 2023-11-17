using ContextualDialogueSystem.Fact;
using System;

namespace ContextualDialogueSystem.Rule.Criteria.Condition
{
    // TODO - Invent some kind of wrapper that avoids [SerializeReference] for generic interfaces
    // TODO - [SF] generic class OK, [SR] non-generic interface OK
    [Serializable]
    internal class FactCriteriaCondition<T> : ICriteriaCondition
    {
        private readonly IFact<T> _fact;
        private readonly IFactCondition<T> _condition;

        public FactCriteriaCondition(IFact<T> fact, IFactCondition<T> condition)
        {
            _fact = fact;
            _condition = condition;
        }

        public bool Satisfies() => _condition.Satisfies(_fact);
    }
}