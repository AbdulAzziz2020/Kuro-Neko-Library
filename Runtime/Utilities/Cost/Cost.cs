using System;
using UnityEngine;

namespace KuroNeko.Library
{
    [Serializable]
    public struct Cost<T>
    {
        [SerializeField] private T type;
        [SerializeField] private float amount;
        
        public T Type => type;
        public float Amount => amount;

        public Cost(T type, float amount)
        {
            this.type = type;
            this.amount = amount;
        }
        
        public static implicit operator T(Cost<T> cost) => cost.Type;
    }
}