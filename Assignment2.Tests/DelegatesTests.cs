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
        Reverse rev = (string str) => {
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
        Product p = (int one, int other) => one*other;
        int one = 4;
        int other = 5;

        var result = p(one,other);

        result.Should().Be(20);
    }
}

delegate void Reverse (String toBeReversed);
delegate int Product (int one, int other);