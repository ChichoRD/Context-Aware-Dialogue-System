using System;
using UnityEngine;

namespace ContextualDialogueSystem.Fact
{
    [CreateAssetMenu(fileName = OBJECT_NAME, menuName = OBJECT_PATH)]
    public class IntegerFactObject : ScriptableObject, IFact<int>, IFact<bool>,
                                                       IObservableFact<int>, IObservableFact<bool>
    {
        private const string OBJECT_NAME = "Integer Fact Object";
        private const string OBJECT_PATH = "Context-Aware-Dialogue-System/Fact/" + OBJECT_NAME;

        private static readonly Func<Action<bool>, Action<int>> s_BoolToIntAction =
            booleanAction =>
                integerValue =>
                    booleanAction(integerValue != 0);

        [SerializeField]
        private int _value;
        public int Value 
        { 
            get => _value;
            set
            {
                _value = value;
                ValueSet?.Invoke(_value);
            }
        }

        bool IFact<bool>.Value
        { 
            get => Value != 0;
            set => Value = value ? 1 : 0;
        }


        public event Action<int> ValueSet;

        event Action<bool> IObservableFact<bool>.ValueSet
        {
            add => ValueSet += s_BoolToIntAction(value);
            remove => ValueSet -= s_BoolToIntAction(value);
        }
    }
}
