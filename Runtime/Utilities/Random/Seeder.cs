namespace KuroNeko.Library
{
    public class SeedRandom : IRandom
    {
        private readonly System.Random random;

        public SeedRandom(int seed)
        {
            random = new System.Random(seed);
        }

        public SeedRandom(long seed)
        {
            random = new System.Random((int)seed);
        }
        
        public int Next(int maxExclusive)
        {
            return random.Next(maxExclusive);
        }

        public int Next(int minInclusive, int maxExclusive)
        {
            return random.Next(minInclusive, maxExclusive);
        }
    }
}