using ContextualDialogueSystem.Rule.Criteria;
using RequireAttributes;
using UnityEngine;

namespace ContextualDialogueSystem.Rule
{
    public abstract class DialogueRuleObject<TContent> : ScriptableObject, IDialogueRule<TContent>
    {
        protected const string OBJECT_NAME = "Dialogue Rule";
        protected const string OBJECT_PATH = "Context-Aware-Dialogue-System/Rule/";

        [RequireInterface(typeof(ICriteria), typeof(ScriptableObject))]
        [SerializeField]
        private Object _criteriaObject;

        [field: SerializeReference]
        protected ICriteria OverrideCriteria { private get; set; }

        public ICriteria Criteria { get; private set; }

        public abstract TContent Content { get; }

        private void OnValidate()
        {
            Criteria = OverrideCriteria ?? _criteriaObject as ICriteria;
        }
    }
}
