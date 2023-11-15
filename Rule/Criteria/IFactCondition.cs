using ContextualDialogueSystem.Fact;
using System;

namespace ContextualDialogueSystem.Rule.Criteria
{
    internal interface IFactCondition<T>
        where T : IEquatable<T>
    {
        // Maybe remove generic type parameter?
        bool Satisfies(IFact<T> fact);
    }
}