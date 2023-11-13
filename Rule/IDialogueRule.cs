using ContextualDialogueSystem.Rule.Criteria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContextualDialogueSystem.Rule
{
    public interface IDialogueRule<out TContent>
    {
        ICriteria Criteria { get; }
        TContent Content { get; }
    }
}
