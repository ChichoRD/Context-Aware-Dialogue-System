using System;

namespace ContextualDialogueSystem.Fact
{
    internal interface IFact<T>
        where T : IEquatable<T>
    {
        T Value { set; get; }
    }
}
