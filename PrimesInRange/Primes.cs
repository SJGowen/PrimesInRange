namespace PrimesInRange;

internal class Primes
{
    internal static IList<int> Generate(int min, int max)
    {
        var primes = new List<int>();

        for (int i = min; i <= max; i++)
        {
            if (IsPrime(i))
            {
                primes.Add(i);
            }
        }

        return primes;
    }

    private static bool IsPrime(int candidate)
    {
        var factor = 2;
        if (candidate <= factor) return candidate == factor;
        do
        {
            if (candidate % factor == 0) return false;
            factor++;
        } while (factor * factor <= candidate);
        return true;
    }
}
