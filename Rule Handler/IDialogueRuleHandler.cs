using ContextualDialogueSystem.Rule;
using ContextualDialogueSystem.Rule.Criteria;

namespace ContextualDialogueSystem.RuleHandler
{
    public interface IDialogueRuleHandler<in TRuleContent>
    {
        bool HandleRule(IDialogueRule<TRuleContent, ICriteria> dialogueRule);
    }
}
