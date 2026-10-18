using System.Collections.Generic;
using System.Linq;

namespace KuroNeko.Library
{
    public static class IEnumerableExtension
    {
        public static T GetRandom<T>(this IReadOnlyList<T> list, IRandom random)
        {
            if (list == null || list.Count == 0)
                return default;

            int index = random.Next(list.Count);

            return list[index];
        }
        
        public static T GetRandom<T>(this IReadOnlyList<T> list)
        {
            if (list == null || list.Count == 0)
                return default;

            int index = UnityEngine.Random.Range(0, list.Count);

            return list[index];
        }
        
        public static List<T> Shuffled<T>(this IEnumerable<T> source, IRandom random)
        {
            List<T> result = source.ToList();

            for (int i = result.Count - 1; i > 0; i--)
            {
                int randomIndex = random.Next(result.Count);

                (result[i], result[randomIndex]) = (result[randomIndex], result[i]);
            }

            return result;
        }
        
        public static List<T> Shuffled<T>(this IEnumerable<T> source)
        {
            List<T> result = source.ToList();

            for (int i = result.Count - 1; i > 0; i--)
            {
                int randomIndex = UnityEngine.Random.Range(0, result.Count);

                (result[i], result[randomIndex]) = (result[randomIndex], result[i]);
            }

            return result;
        }
        
        public static void Shuffled<T>(this IList<T> p_source)
        {
            for (int i = p_source.Count - 1; i > 0; i--)
            {
                int l_randomIndex = UnityEngine.Random.Range(0, i + 1);

                (p_source[i], p_source[l_randomIndex]) =
                    (p_source[l_randomIndex], p_source[i]);
            }
        }
    }
}