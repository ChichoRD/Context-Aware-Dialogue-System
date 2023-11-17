using ContextualDialogueSystem.Fact;
using System;
using UnityEngine;

namespace ContextualDialogueSystem.Rule.Criteria
{
    [Serializable]
    internal class ValueEqualityCondition<T> : IFactCondition<T>
        where T : IEquatable<T>
    {
        [SerializeField]
        private T _value;
        public ValueEqualityCondition(T value) => _value = value;
        public bool Satisfies<U>(IFact<U> fact)
            where U : T => fact.Value.Equals(_value);
    }
}