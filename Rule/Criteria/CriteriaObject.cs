using ContextualDialogueSystem.Fact;
using ContextualDialogueSystem.Rule.Criteria.Condition;
using UnityEngine;

namespace ContextualDialogueSystem.Rule.Criteria
{
    [CreateAssetMenu(fileName = OBJECT_NAME, menuName = OBJECT_PATH)]
    public class CriteriaObject : ScriptableObject, ICriteria
    {
        private const string OBJECT_NAME = "Criteria Object";
        private const string OBJECT_PATH = "Context-Aware-Dialogue-System/Rule/Criteria/" + OBJECT_NAME;

        [SerializeField]
        private SimultaneousCriteria _simultaneousCriteria;
        public bool IsMet() => _simultaneousCriteria.IsMet();

        // TODO - Invert type selection

        [ContextMenu(nameof(AddValueEqualityCondition))]
        private void AddValueEqualityCondition()
        {
            FactCriteriaCondition<int> condition = new CriteriaExtensions.IntegerFactCriteriaCondition(
                            null,
                            new CriteriaExtensions.IntegerValueEqualityCondition(0));
            _simultaneousCriteria.Conditions.Add(condition);
        }

        [ContextMenu(nameof(AddOrderingCondition))]
        private void AddOrderingCondition()
        {
            FactCriteriaCondition<int> condition = new CriteriaExtensions.IntegerFactCriteriaCondition(
                            null,
                            new CriteriaExtensions.IntegerOrderingCondition(0, OrderingComparison.LessThan));
            _simultaneousCriteria.Conditions.Add(condition);
        }

        [ContextMenu(nameof(DebugCriteria))]
        private void DebugCriteria()
        {
            Debug.Log(_simultaneousCriteria.IsMet());
        }
    }
}