using ContextualDialogueSystem.Rule.Content;
using ContextualDialogueSystem.Rule.Criteria;
using ContextualDialogueSystem.Rule.Criteria.Condition;
using UnityEngine;

namespace ContextualDialogueSystem.Rule
{
    [CreateAssetMenu(fileName = OBJECT_NAME, menuName = OBJECT_PATH)]
    public class SpeechDialogueRuleObject : ScriptableObject, IDialogueRule<ISpeechContent<string>, ICriteria>
    {
        private const string OBJECT_NAME = "Speech Dialogue Rule";
        private const string OBJECT_PATH = "Context-Aware-Dialogue-System/Rule/" + OBJECT_NAME;

        [SerializeField]
        private DialogueRule<SpeechContent, SimultaneousCriteria> _rule;
        public ISpeechContent<string> Content => _rule.Content;
        public ICriteria Criteria => _rule.Criteria;


        [ContextMenu(nameof(ClearCriteria))]
        private void ClearCriteria() => _rule = new DialogueRule<SpeechContent, SimultaneousCriteria>(null, _rule.Content);

        [ContextMenu(nameof(ClearContent))]
        private void ClearContent() => _rule = new DialogueRule<SpeechContent, SimultaneousCriteria>(_rule.Criteria, default);

        [ContextMenu(nameof(SetCriteriaToNewSimultaneous))]
        private void SetCriteriaToNewSimultaneous() => _rule = new DialogueRule<SpeechContent, SimultaneousCriteria>(new SimultaneousCriteria(), _rule.Content);

        [ContextMenu(nameof(AddValueEqualityCondition))]
        private void AddValueEqualityCondition()
        {
            if (_rule.Criteria == null)
                SetCriteriaToNewSimultaneous();

            FactCriteriaCondition<int> condition = new CriteriaExtensions.IntegerFactCriteriaCondition(
                            null,
                            new CriteriaExtensions.IntegerValueEqualityCondition(0));
            _rule.Criteria.Conditions.Add(condition);
        }

        [ContextMenu(nameof(AddOrderingCondition))]
        private void AddOrderingCondition()
        {
            if (_rule.Criteria == null)
                SetCriteriaToNewSimultaneous();

            FactCriteriaCondition<int> condition = new CriteriaExtensions.IntegerFactCriteriaCondition(
                            null,
                            new CriteriaExtensions.IntegerOrderingCondition(0, OrderingComparison.LessThan));
            _rule.Criteria.Conditions.Add(condition);
        }
    }
}
