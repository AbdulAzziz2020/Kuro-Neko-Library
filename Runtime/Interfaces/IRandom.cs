namespace KuroNeko.Library
{
    public interface IRandom
    {
        int Next(int maxExclusive);
        int Next(int minInclusive, int maxExclusive);
    }
}