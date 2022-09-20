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
}

delegate void Reverse (String toBeReversed);
