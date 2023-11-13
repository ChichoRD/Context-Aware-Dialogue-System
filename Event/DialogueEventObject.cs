using ContextualDialogueSystem.Rule;
using ContextualDialogueSystem.RuleHandler;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace ContextualDialogueSystem.Event
{
    public class DialogueEventObject : ScriptableObject, IDispatchableDialogueEvent, IObservableDialogueEvent
    {
        [SerializeField]
        private Object[] _dialogueRuleObjects;
        private IEnumerable<IDialogueRule<object>> _dialogueRules;

        public event RuleDispatch<object> RuleDispatched;

        public void Dispatch()
        {
            _dialogueRules = _dialogueRuleObjects.OfType<IDialogueRule<object>>();

            foreach (var rule in _dialogueRules)
                if (rule.Criteria.IsMet())
                    RuleDispatched?.Invoke(rule);
        }

        public bool Subscribe<TRuleContent>(IDialogueRuleHandler<TRuleContent> dialogueRuleHandler)
        {
            RuleDispatched += dialogueRuleHandler.HandleRule<TRuleContent>;
            return true;
        }

        public bool Unsubscribe<TRuleContent>(IDialogueRuleHandler<TRuleContent> dialogueRuleHandler)
        {
            RuleDispatched -= dialogueRuleHandler.HandleRule<TRuleContent>;
            return true;
        }
    }
}