using System;
using System.Collections.Generic;

namespace KuroNeko.Library
{
    public static class CostTExtensions
    {
        public static Cost<T> GetDrop<T>(this IEnumerable<Cost<T>> list)
        {
            if (list == null)
                return default;

            float totalWeight = 0f;
            foreach (var cost in list)
            {
                totalWeight += cost.Amount;
            }
            
            if(totalWeight <= 0f) 
                return default;

            float random = UnityEngine.Random.value * totalWeight;
            float cumulative = 0f;
            foreach (var cost in list)
            {
                cumulative += cost.Amount;
                if(random <= cumulative)
                    return cost;
            }

            return default;
        }

        public static CostInt<T> GetDrop<T>(this IEnumerable<CostInt<T>> list)
        {
            if (list == null)
                return default;

            float totalWeight = 0f;
            foreach (var cost in list)
            {
                totalWeight += cost.Amount;
            }
            
            if(totalWeight <= 0f) 
                return default;

            float random = UnityEngine.Random.value * totalWeight;
            float cumulative = 0f;
            foreach (var cost in list)
            {
                cumulative += cost.Amount;
                if(random <= cumulative)
                    return cost;
            }

            return default;
            
        }
        
        public static float ToSeconds(this Cost<TimeType> cost)
        {
            return cost.Type switch
            {
                TimeType.Milliseconds => cost.Amount / 1000,
                TimeType.Seconds => cost.Amount,
                TimeType.Minutes => cost.Amount * 60,
                TimeType.Hours => cost.Amount * 60 * 60,
                TimeType.Days => cost.Amount * 60 * 60 * 24,
                TimeType.Weeks => cost.Amount * 60 * 60 * 24 * 7,
                TimeType.Months => cost.Amount * 60 * 60 * 24 * 30,
                TimeType.Years => cost.Amount * 60 * 60 * 24 * 365,
                _ => 0
            };
        }

        public static TimeSpan ToTimeSpan(this CostInt<TimeType> cost)
        {
            return cost.Type switch
            {
                TimeType.Milliseconds => TimeSpan.FromMilliseconds(cost.Amount),
                TimeType.Seconds => TimeSpan.FromSeconds(cost.Amount),
                TimeType.Minutes => TimeSpan.FromMinutes(cost.Amount),
                TimeType.Hours => TimeSpan.FromHours(cost.Amount),
                TimeType.Days => TimeSpan.FromDays(cost.Amount),
                TimeType.Weeks => TimeSpan.FromDays(cost.Amount * 7),
                TimeType.Months => TimeSpan.FromDays(cost.Amount * 30),
                TimeType.Years => TimeSpan.FromDays(cost.Amount * 365),
                _ => TimeSpan.Zero
            };
        }

        public static long ToSeconds(this CostInt<TimeType> cost)
        {
            return cost.Type switch
            {
                TimeType.Milliseconds => cost.Amount / 1000,
                TimeType.Seconds => cost.Amount,
                TimeType.Minutes => cost.Amount * 60,
                TimeType.Hours => cost.Amount * 60 * 60,
                TimeType.Days => cost.Amount * 60 * 60 * 24,
                TimeType.Weeks => cost.Amount * 60 * 60 * 24 * 7,
                TimeType.Months => cost.Amount * 60 * 60 * 24 * 30,
                TimeType.Years => cost.Amount * 60 * 60 * 24 * 365,
                _ => 0
            };
        }
        
        public static long ToMinutes(this CostInt<TimeType> cost)
        {
            return cost.Type switch
            {
                TimeType.Milliseconds => cost.Amount / 1000 / 60,
                TimeType.Seconds => cost.Amount / 60,
                TimeType.Minutes => cost.Amount,
                TimeType.Hours => cost.Amount * 60,
                TimeType.Days => cost.Amount * 60 * 24,
                TimeType.Weeks => cost.Amount * 60 * 24 * 7,
                TimeType.Months => cost.Amount * 60 * 24 * 30,
                TimeType.Years => cost.Amount * 60 * 24 * 365,
                _ => 0
            };
        }
    }
}