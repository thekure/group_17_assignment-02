namespace Assignment2.Tests;

public class WizardTests
{
    [Fact]
    public void WizardCollection_contains_12_wizards()
    {
        var wizards = WizardCollection.Create();

        Assert.Equal(12, wizards.Count());
    }

    [Theory]
    [InlineData("Darth Vader", "Star Wars", 1977, "George Lucas")]
    [InlineData("Sauron", "The Fellowship of the Ring", 1954, "J.R.R. Tolkien")]
    public void Spot_check_wizards(string name, string medium, int year, string creator)
    {
        var wizards = WizardCollection.Create();

        Assert.Contains(wizards, w => w == new Wizard(name, medium, year, creator));
    }
}

