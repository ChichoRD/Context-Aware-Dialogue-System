using ContextualDialogueSystem.Fact;
using System.Collections.Generic;
using UnityEngine;

namespace ContextualDialogueSystem.Rule.Criteria
{
    [CreateAssetMenu(fileName = OBJECT_NAME, menuName = OBJECT_PATH)]
    public class CriteriaObject : ScriptableObject, ICriteria
    {
        private const string OBJECT_NAME = "Criteria Object";
        private const string OBJECT_PATH = "Context-Aware-Dialogue-System/Rule/Criteria/" + OBJECT_NAME;

        [SerializeReference]
        private List<ICriteriaCondition> _factConditions = new List<ICriteriaCondition>();

        public bool IsMet() => _factConditions.TrueForAll(factCondition => factCondition.Satisfies());

        [ContextMenu(nameof(AddEqualityFactCondition))]
        private void AddEqualityFactCondition() => _factConditions.Add(new IntegerFactCriteriaCondition(null, new ValueEqualityCondition(default)));

        [ContextMenu(nameof(AddOrderingFactCondition))]
        private void AddOrderingFactCondition() => _factConditions.Add(new IntegerFactCriteriaCondition(null, new OrderingCondition(default, default)));

        [ContextMenu(nameof(DebugIsMet))]
        private void DebugIsMet() => Debug.Log(IsMet());

        private interface IIntegerFactCondition : IFactCondition<int> { }

        private class IntegerFactCriteriaCondition : ICriteriaCondition
        {
            [SerializeField]
            private IntegerFactObject _fact;

            [SerializeReference]
            private IIntegerFactCondition _condition;

            public IntegerFactCriteriaCondition(IntegerFactObject fact, IIntegerFactCondition condition)
            {
                _fact = fact;
                _condition = condition;
            }

            public bool Satisfies() => _condition.Satisfies<int>(_fact);
        }

        private class OrderingCondition : OrderingCondition<int>, IIntegerFactCondition
        {
            public OrderingCondition(int value, OrderingComparison orderingComparison) : base(value, orderingComparison)
            {
            }
        }

        private class ValueEqualityCondition : ValueEqualityCondition<int>, IIntegerFactCondition
        {
            public ValueEqualityCondition(int value) : base(value)
            {
            }
        }
    }
}