using System;
using UnityEngine;

namespace KuroNeko.Library
{
    [Serializable]    
    public struct CostInt<T>
    {
        [SerializeField] private T type;
        [SerializeField] private int amount;

        public T Type => type;
        public int Amount => amount;
        
        public CostInt(T type, int amount)
        {
            this.type = type;
            this.amount = amount;
        }
        
        public static implicit operator T(CostInt<T> costInt) => costInt.Type;
    }
}