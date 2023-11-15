using System;
using UnityEngine;

namespace ContextualDialogueSystem.Fact
{
    public class IntegerFactObject : ScriptableObject, IFact<int>, IFact<bool>,
                                                       IObservableFact<int>, IObservableFact<bool>
    {
        private static readonly Func<Action<bool>, Action<int>> s_BoolToIntAction =
            booleanAction =>
                integerValue =>
                    booleanAction(integerValue != 0);

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
