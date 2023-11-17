using System;
using UnityEngine;

namespace ContextualDialogueSystem.Fact
{
    [CreateAssetMenu(fileName = OBJECT_NAME, menuName = OBJECT_PATH)]
    public class FloatFactObject : ScriptableObject, IFact<float>,
                                                     IObservableFact<float>
    {
        private const string OBJECT_NAME = "Float Fact Object";
        private const string OBJECT_PATH = "Context-Aware-Dialogue-System/Fact/" + OBJECT_NAME;

        [SerializeField]
        private float _value;
        public float Value
        {
            get => _value;
            set
            {
                _value = value;
                ValueSet?.Invoke(_value);
            }
        }

        public event Action<float> ValueSet;
    }
}
