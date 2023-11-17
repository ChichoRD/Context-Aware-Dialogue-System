using ContextualDialogueSystem.Rule.Criteria;

namespace ContextualDialogueSystem.Rule
{
    public interface IDialogueRule<out TContent>
    {
        ICriteria Criteria { get; }
        TContent Content { get; }
    }
}
