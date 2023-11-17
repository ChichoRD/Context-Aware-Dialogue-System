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
        private OrderingCondition<int> _orderingCondition;

        [SerializeField]
        private SimultaneousCriteria _simultaneousCriteria;

        public bool IsMet()
        {
            throw new System.NotImplementedException();
        }

        [ContextMenu(nameof(DebugCriteria))]
        private void DebugCriteria()
        {
            _simultaneousCriteria.TestConditions.Add(new FactCriteriaCondition<bool>(
                default,
                //new OrderingCondition<int>(
                //    default,
                //    default))
                default));
            foreach (var condition in _simultaneousCriteria.TestConditions)
                Debug.Log(condition);
        }
    }
}