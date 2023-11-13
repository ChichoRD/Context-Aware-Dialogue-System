using ContextualDialogueSystem.Rule;

namespace ContextualDialogueSystem.RuleHandler
{
    internal static class DialogueRuleHandlerExtensions
    {
        public static bool HandleRule<TRuleContent>(this IDialogueRuleHandler<TRuleContent> dialogueRuleHandler, IDialogueRule<object> dialogueRule) =>
            dialogueRule is IDialogueRule<TRuleContent> rule && dialogueRuleHandler.HandleRule(rule);
    }
}
