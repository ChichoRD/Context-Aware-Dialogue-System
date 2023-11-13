
using ContextualDialogueSystem.RuleHandler;

namespace ContextualDialogueSystem.Event
{
    internal interface IObservableDialogueEvent
    {
        bool Subscribe<TRuleContent>(IDialogueRuleHandler<TRuleContent> dialogueRuleHandler);
        bool Unsubscribe<TRuleContent>(IDialogueRuleHandler<TRuleContent> dialogueRuleHandler);
    }
}