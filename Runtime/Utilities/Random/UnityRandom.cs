namespace KuroNeko.Library
{
    public class UnityRandom : IRandom
    {
        public int Next(int maxExclusive)
        {
            return UnityEngine.Random.Range(0, maxExclusive);
        }

        public int Next(int minInclusive, int maxExclusive)
        {
            return UnityEngine.Random.Range(minInclusive, maxExclusive);
        }
    }
}