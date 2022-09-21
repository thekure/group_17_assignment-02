namespace Assignment2.Tests;

public class DelegatesTests
{
    [Fact]
    public void Reverse_given_teststr_returns_rtstset()
    {
        Console.Clear();
        using var writer = new StringWriter();
        var str = "teststr";
        Console.SetOut(writer);
        Action<string> rev = (string str) => {
            foreach (var c in str.Reverse())
            {
                Console.Write(c);
            }
        };

        rev(str);

        var output = writer.GetStringBuilder().ToString().TrimEnd();
        output.Should().Be("rtstset");
    }

    [Fact]
    public void Product_when_given_4_5_returns_20()
    {
        Func<int,int,int> p = (int one, int other) => one*other;
        int one = 4;
        int other = 5;

        var result = p(one,other);

        result.Should().Be(20);
    }

    [Fact]
    public void CompareStrInt_when_given_0042_42_returns_true()
    {
        Func<string, int, bool> compr = (string str, int val) => Int32.Parse(str) == val;
        var strVal = "  0042";
        var intVal = 42;

        var result = compr(strVal, intVal);

        result.Should().Be(true);
    }
}