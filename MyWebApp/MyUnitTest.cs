namespace MyUnitTest;

using Xunit;

public class Calculator
{
    public static int Add(int a, int b)
    {
        return a + b;
    }
}

public class MyTests
{
    [Fact]
    public void TestAddition()
    {
        int result = Calculator.Add(2, 3);
        Assert.Equal(5, result);
    }

    [Fact]
    public void AddingTwoNumbers_ShouldReturnCorrectSum()
    {
        int result = Calculator.Add(3, 4);
        Assert.Equal(7, result);
    }

    [Fact]
    public void AddingTwoNegativeNumbers_ShouldReturnCorrectSum()
    {
        int result = Calculator.Add(-3, -4);
        Assert.Equal(-7, result);
    }
}