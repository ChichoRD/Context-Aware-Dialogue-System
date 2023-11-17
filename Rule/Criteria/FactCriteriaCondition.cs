using ContextualDialogueSystem.Fact;
using System;
using UnityEngine;

namespace ContextualDialogueSystem.Rule.Criteria
{
    // TODO - Invent some kind of wrapper that avoids [SerializeReference] for generic interfaces
    // TODO - [SF] generic class OK, [SR] non-generic interface OK
    [Serializable]
    internal class FactCriteriaCondition<T> : ICriteriaCondition
    {
        [SerializeReference]
        private IFact<T> _fact;
        [SerializeReference]
        private IFactCondition<T> _condition;

        public FactCriteriaCondition(IFact<T> fact, IFactCondition<T> condition)
        {
            _fact = fact;
            _condition = condition;
        }

        public bool Satisfies() => _condition.Satisfies(_fact);
    }
}