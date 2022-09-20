namespace Assignment2.Tests;

public class QueriesTests
{
    [Fact]
    public void Get_Rowling_wizards_returns_harry_potter_dumbledore_voldemort()
    {
        var collection = WizardCollection.Create();
        var expected = new List<string>(){"Harry Potter", "Dumbledore", "Voldemort"};

        var resultFromExtensions = Queries.GetRowlingWizardsWithExtensions(collection);
        var resultFromLinq = Queries.GetRowlingWizardsWithLinqQuery(collection);

        resultFromExtensions.Should().BeEquivalentTo(expected);
        resultFromLinq.Should().BeEquivalentTo(expected);
        resultFromExtensions.Should().BeEquivalentTo(resultFromLinq);
    }

    
}

