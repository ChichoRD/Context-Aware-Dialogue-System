using ContextualDialogueSystem.Rule.Criteria.Condition;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace ContextualDialogueSystem.Rule.Criteria
{
    [Serializable]
    internal class SimultaneousCriteria : ICriteria
    {
        [field: SerializeReference]
        public List<ICriteriaCondition> TestConditions { get; private set; } = new List<ICriteriaCondition>() { new FactCriteriaCondition<int>(default, default) };

        private readonly IEnumerable<ICriteriaCondition> _conditions;

        public SimultaneousCriteria(IEnumerable<ICriteriaCondition> conditions)
        {
            _conditions = conditions;
        }

        public bool IsMet() => _conditions.All(condition => condition.Satisfies());
    }
}