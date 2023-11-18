using ContextualDialogueSystem.Rule;
using ContextualDialogueSystem.Rule.Criteria;

namespace ContextualDialogueSystem.RuleHandler
{
    internal static class DialogueRuleHandlerExtensions
    {
        public static bool HandleRule<TRuleContent>(this IDialogueRuleHandler<TRuleContent> dialogueRuleHandler, IDialogueRule<object, ICriteria> dialogueRule) =>
            dialogueRule is IDialogueRule<TRuleContent, ICriteria> rule && dialogueRuleHandler.HandleRule(rule);
    }
}
