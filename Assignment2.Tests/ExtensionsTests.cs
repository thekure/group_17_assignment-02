namespace Assignment2.Tests;

public class ExtensionsTests
{
    [Fact]
    public void IsSecure_given_itu_webiste_returns_true()
    {
        var uri = new Uri("https://itu.dk");

        var result = uri.IsSecure();

        result.Should().Be(true);
    }

    [Fact]
    public void WordCount_given_hello_i_am_coding_returns_4(){
        var str = "hello i am coding";

        var result = str.WordCount();

        result.Should().Be(4);
    }
}
