namespace ContextualDialogueSystem.Rule.Criteria.Condition
{
    internal interface ICriteriaConditionFactory
    {
        ICriteriaCondition Create();
        ICriteriaConditionFactory TryConfigureWith<T>(IFactCondition<T> value);
    }
}