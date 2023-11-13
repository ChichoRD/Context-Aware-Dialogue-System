using ContextualDialogueSystem.Rule;

namespace ContextualDialogueSystem.Event
{
    public delegate bool RuleDispatch<in TRuleContent>(IDialogueRule<TRuleContent> dialogueRule);
}