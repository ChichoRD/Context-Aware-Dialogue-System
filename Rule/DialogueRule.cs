using ContextualDialogueSystem.Rule.Criteria;
using RequireAttributes;
using System;
using UnityEngine;

namespace ContextualDialogueSystem.Rule
{
    [Serializable]
    public class DialogueRule<TContent, TCriteria> : IDialogueRule<TContent, TCriteria>
        where TCriteria : class, ICriteria
    {
        [RequireInterface(typeof(ICriteria), typeof(ScriptableObject))]
        [SerializeField]
        private ScriptableObject _criteriaObject;

        [SerializeReference]
        private TCriteria _criteria;
        public TCriteria Criteria 
        {
            get => _criteria ?? _criteriaObject as TCriteria;
            private set =>_criteria = value;
        }

        [field: SerializeField]
        public TContent Content { get; private set; }

        public DialogueRule(TCriteria criteria, TContent content)
        {
            Criteria = criteria;
            Content = content;
        }
    }
}
