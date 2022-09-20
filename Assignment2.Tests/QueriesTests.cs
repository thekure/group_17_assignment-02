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

    [Fact]
    public void Get_First_Sithlord_returns_1977(){
        var collection = WizardCollection.Create();

        var resultFromExtensions = Queries.GetFirstSithlordWithExtensions(collection);
        var resultFromLinq = Queries.GetFirstSithlordWithLinqQuery(collection);

        resultFromExtensions.Should().Be(1977);
        resultFromLinq.Should().Be(1977);
        resultFromExtensions.Should().Be(resultFromLinq);
    }

    
}

