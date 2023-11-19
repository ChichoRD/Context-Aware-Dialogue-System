using System.Threading.Tasks;

namespace ContextualDialogueSystem.RuleHandler.Typewriting
{
    public delegate bool TypingStateFunc(string typedMessage, out Task stateTask);
}