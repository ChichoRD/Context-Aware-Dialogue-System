using ContextualDialogueSystem.Fact;

namespace ContextualDialogueSystem.Rule.Criteria.Condition
{
    internal interface IFactCondition<in T>
    {
        bool Satisfies<U>(IFact<U> fact)
            where U : T;
    }
}