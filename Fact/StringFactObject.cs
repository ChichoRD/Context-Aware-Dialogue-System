using UnityEngine;

namespace ContextualDialogueSystem.Fact
{
    [CreateAssetMenu(fileName = OBJECT_NAME, menuName = OBJECT_PATH)]
    public class StringFactObject : ScriptableObject, IFact<string>,
                                                      IObservableFact<string>
    {
        private const string OBJECT_NAME = "String Fact Object";
        private const string OBJECT_PATH = "Context-Aware-Dialogue-System/Fact/" + OBJECT_NAME;

        [SerializeField]
        private string _value;
        public string Value
        {
            get => _value;
            set
            {
                _value = value;
                ValueSet?.Invoke(_value);
            }
        }

        public event FactValueAction<string> ValueSet;
    }
}
