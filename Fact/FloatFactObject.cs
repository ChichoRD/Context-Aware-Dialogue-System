using System;
using UnityEngine;

namespace ContextualDialogueSystem.Fact
{
    public class FloatFactObject : ScriptableObject, IFact<float>,
                                                     IObservableFact<float>
    {
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
