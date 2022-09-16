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
}
