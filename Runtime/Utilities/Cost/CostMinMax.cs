using System;
using UnityEngine;

namespace KuroNeko.Library
{
    [Serializable]    
    public struct CostMinMax<T>
    {
        [SerializeField] private T type;
        [SerializeField] private float min;
        [SerializeField] private float max;

        public T Type => type;
        public float Random => UnityEngine.Random.Range(min, max + 1);
        public float Min => min;
        public float Max => max;
        
        public CostMinMax(T type, float min, float max)
        {
            this.type = type;
            this.min = min;
            this.max = max;
        }
        
        public static implicit operator Cost<T>(CostMinMax<T> costMinMax)
        {
            return new Cost<T>(costMinMax.Type, costMinMax.Random);
        }
    }
}