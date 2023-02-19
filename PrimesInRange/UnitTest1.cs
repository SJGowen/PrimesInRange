namespace PrimesInRange;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Assert.Equal(ExpectedList(), Primes.Generate(1, 1));
        Assert.Equal(ExpectedList(2), Primes.Generate(1, 2));
        Assert.Equal(ExpectedList(2, 3), Primes.Generate(1, 3));
        Assert.Equal(ExpectedList(2, 3), Primes.Generate(1, 4));
        Assert.Equal(ExpectedList(2, 3, 5), Primes.Generate(1, 5));
        Assert.Equal(ExpectedList(2, 3, 5), Primes.Generate(1, 6));
        Assert.Equal(ExpectedList(2, 3, 5, 7), Primes.Generate(1, 7));
        Assert.Equal(ExpectedList(2, 3, 5, 7), Primes.Generate(1, 8));
        Assert.Equal(ExpectedList(2, 3, 5, 7), Primes.Generate(1, 9));
        Assert.Equal(ExpectedList(2, 3, 5, 7), Primes.Generate(1, 10));
        Assert.Equal(ExpectedList(2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97), Primes.Generate(1, 100));
        Assert.Equal(ExpectedList(31, 37, 41, 43, 47, 53, 59), Primes.Generate(31, 59));
    }

    private IList<int> ExpectedList(params int[] expectedFactors) => expectedFactors.ToList();
}