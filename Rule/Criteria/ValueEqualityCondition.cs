using ContextualDialogueSystem.Fact;
using System;

namespace ContextualDialogueSystem.Rule.Criteria
{
    [Serializable]
    internal class ValueEqualityCondition<T> : IFactCondition<T>
        where T : IEquatable<T>
    {
        private readonly T _value;
        public ValueEqualityCondition(T value) => _value = value;
        public bool Satisfies(IFact<T> fact) => fact.Value.Equals(_value);
    }
}