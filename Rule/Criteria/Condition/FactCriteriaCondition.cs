using ContextualDialogueSystem.Fact;
using UnityEngine;

namespace ContextualDialogueSystem.Rule.Criteria.Condition
{
    // TODO - Invent some kind of wrapper that avoids [SerializeReference] for generic interfaces
    // TODO - [SF] generic class OK, [SR] non-generic interface OK
    internal class FactCriteriaCondition<T> : ICriteriaCondition
    {
        [SerializeField]
        private ScriptableObject _factObject;

        private IFact<T> _fact;
        public IFact<T> Fact 
        { 
            get => _fact ?? _factObject as IFact<T>; 
            private set => _fact = value;
        }

        [field: SerializeReference]
        public IFactCondition Condition { private get; set; }

        public FactCriteriaCondition(IFact<T> fact, IFactCondition<T> condition)
        {
            Fact = fact;
            Condition = condition;
        }

        public bool Satisfies() => Condition.Satisfies(Fact);
    }
}