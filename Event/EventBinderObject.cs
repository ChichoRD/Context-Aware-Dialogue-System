using ContextualDialogueSystem.RuleHandler;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace ContextualDialogueSystem.Event
{
    public class EventBinderObject : ScriptableObject, IObservableDialogueEvent
    {
        [SerializeField]
        private Object[] _dialogueEventObjects;
        private IEnumerable<IObservableDialogueEvent> _dialogueEvents;

        public bool Subscribe<TRuleContent>(IDialogueRuleHandler<TRuleContent> dialogueRuleHandler)
        {
            _dialogueEvents = _dialogueEventObjects.OfType<IObservableDialogueEvent>();
            bool success = true;

            foreach (var dialogueEvent in _dialogueEvents)
                success &= dialogueEvent.Subscribe(dialogueRuleHandler);

            return success;
        }

        public bool Unsubscribe<TRuleContent>(IDialogueRuleHandler<TRuleContent> dialogueRuleHandler)
        {
            _dialogueEvents = _dialogueEventObjects.OfType<IObservableDialogueEvent>();
            bool success = true;

            foreach (var dialogueEvent in _dialogueEvents)
                success &= dialogueEvent.Unsubscribe(dialogueRuleHandler);

            return success;
        }
    }
}