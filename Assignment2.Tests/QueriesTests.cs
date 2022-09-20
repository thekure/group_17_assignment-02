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

    [Fact]
    public void Get_unique_harry_potter_wizards_returns_harry_potter_1997_dumbledore_1997_voldemort_1997()
    {
        var collection = WizardCollection.Create();
        var expected = new List<(string, int)>(){("Harry Potter", 1997),("Dumbledore",1997),("Voldemort", 1997)};

        var resultFromExtensions = Queries.GetUniqueHarryPotterWizardsWithExtensions(collection);
        var resultFromLinq = Queries.GetUniqueHarryPotterWizardsWithLinqQuery(collection);        

        resultFromExtensions.Should().BeEquivalentTo(expected);
        resultFromLinq.Should().BeEquivalentTo(expected);
        resultFromExtensions.Should().BeEquivalentTo(resultFromLinq);
    }

    [Fact]
    public void Get_ordered_wizard_names_returns_ordered_names()
    {
        var collection = WizardCollection.Create();
        var expected = new List<string>(){"Dr. Strange",                                    //Steve Ditko -group
                                          "The Wizard of Oz",                               //L. Frank Baum -group
                                          "Gandalf","Sauron",                               //J.R.R. Tolkien -group
                                          "Dumbledore","Harry Potter","Voldemort",          //J.K. Rowling -group
                                          "Jafar",                                          //Guy Ritchie -group
                                          "Darth Sidious","Darth Vader","Luke Skywalker",   //George Lucas -group
                                          "The White Witch"};                               //C.S. Lewis -group
        
        var resultFromExtension = Queries.GetWizardNamesGroupedByCreatorOrderedByReverseCreatorNameAndThenWizardNameWithExtensions(collection);
        var resultFromLinq = Queries.GetWizardNamesGroupedByCreatorOrderedByReverseCreatorNameAndThenWizardNameWithLinqQuery(collection);

        Assert.Equal(expected, resultFromExtension);
        Assert.Equal(expected, resultFromLinq);
        Assert.Equal(resultFromExtension, resultFromLinq);
    }
    
}

