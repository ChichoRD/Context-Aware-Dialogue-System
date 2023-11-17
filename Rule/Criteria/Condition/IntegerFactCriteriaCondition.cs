using ContextualDialogueSystem.Fact;
using System;
using UnityEngine;

namespace ContextualDialogueSystem.Rule.Criteria.Condition
{
    [Serializable]
    [Obsolete]
    internal class IntegerFactCriteriaCondition : ICriteriaCondition
    {
        [SerializeReference]
        private IIntegerFact _fact;

        [SerializeReference]
        private IIntegerFactCondition _condition;

        public bool Satisfies() => _condition.Satisfies(_fact);

        internal interface IIntegerFact : IFact<int> { }

        internal interface IIntegerFactCondition : IFactCondition<int> { }
    }
}