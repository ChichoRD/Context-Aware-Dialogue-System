using ContextualDialogueSystem.Rule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContextualDialogueSystem.RuleHandler
{
    public interface IDialogueRuleHandler<in TRuleContent>
    {
        bool HandleRule(IDialogueRule<TRuleContent> dialogueRule);
    }
}
