using ContextualDialogueSystem.Fact;
using System;

namespace ContextualDialogueSystem.Rule.Criteria
{
    [Serializable]
    internal class OrderingCondition<T> : IFactCondition<T>
        where T : IEquatable<T>, IComparable<T>
    {
        private readonly T _value;
        private readonly OrderingComparison _orderingComparison;
        public OrderingCondition(T value, OrderingComparison orderingComparison)
        {
            _value = value;
            _orderingComparison = orderingComparison;
        }

        public bool Satisfies(IFact<T> fact) => _orderingComparison switch
        {
            OrderingComparison.LessThan => fact.Value.CompareTo(_value) < 0,
            OrderingComparison.LessThanOrEqual => fact.Value.CompareTo(_value) <= 0,
            OrderingComparison.Equal => fact.Value.CompareTo(_value) == 0,
            OrderingComparison.NotEqual => fact.Value.CompareTo(_value) != 0,
            OrderingComparison.GreaterThanOrEqual => fact.Value.CompareTo(_value) >= 0,
            OrderingComparison.GreaterThan => fact.Value.CompareTo(_value) > 0,
            _ => throw new NotImplementedException()
        };
    }
}