namespace KuroNeko.Library
{
    public static class RandomProvider
    {
        public static IRandom Default => new UnityRandom();
        
        public static IRandom FromSeed(int seed)
        {
            return new SeedRandom(seed);
        }
    }
}