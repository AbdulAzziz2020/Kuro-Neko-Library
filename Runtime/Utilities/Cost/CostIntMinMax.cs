using System;
using Feline.Core;
using UnityEngine;

namespace KuroNeko.Library
{
    [Serializable]    
    public struct CostIntMinMax<T>
    {
        [SerializeField] private T type;
        [SerializeField] private int min;
        [SerializeField] private int max;

        public T Type => type;
        public int Random => UnityEngine.Random.Range(min, max + 1);
        public int Min => min;
        public int Max => max;
        
        public CostIntMinMax(T type, int min, int max)
        {
            this.type = type;
            this.min = min;
            this.max = max;
        }

        public static implicit operator CostInt<T>(CostIntMinMax<T> costIntMinMax)
        {
            return new CostInt<T>(costIntMinMax.Type, costIntMinMax.Random);
        }
    }
}