using System;

namespace ContextualDialogueSystem.Fact
{
    internal interface IObservableFact<T>
    {
        event Action<T> ValueSet;
    }
}
