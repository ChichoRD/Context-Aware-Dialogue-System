using ContextualDialogueSystem.Rule;
using ContextualDialogueSystem.Rule.Criteria;

namespace ContextualDialogueSystem.Event
{
    public delegate bool RuleDispatch<in TRuleContent>(IDialogueRule<TRuleContent, ICriteria> dialogueRule);
}