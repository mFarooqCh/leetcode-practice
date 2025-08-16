using System;

namespace Round01.Tests;

public sealed class EasyStringTests
{
    /// <summary>
    /// 3340: check if the sum of digits at even indices equals the sum at odd indices.
    /// </summary>
    [Fact]
    public void ShouldCheckBalanceString()
    {
        //fail
        var num = "1234";
        //pass
        var num2 = "24123";

        bool issuccess = CheckBalanceString(num);
        Assert.True(issuccess);
    }

    private bool CheckBalanceString(string numbers)
    {
        int evenSum = 0;
        int oddSum = 0;
        short index = 0;
        foreach (char c in numbers.ToCharArray())
        {
            if (index % 2 == 0)
                evenSum+= int.Parse(c.ToString());
            else
                oddSum += int.Parse(c.ToString());
        }
        return evenSum == oddSum;
    }
}
