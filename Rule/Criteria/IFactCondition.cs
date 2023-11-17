using ContextualDialogueSystem.Fact;

namespace ContextualDialogueSystem.Rule.Criteria
{
    internal interface IFactCondition<in T>
    {
        bool Satisfies<U>(IFact<U> fact)
            where U : T;
    }
}