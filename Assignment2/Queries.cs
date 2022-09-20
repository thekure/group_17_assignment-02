namespace Assignment2;

public class Queries
{
    public static IEnumerable<string> GetRowlingWizardsWithExtensions(WizardCollection wizards)
    {
        return wizards.Where(wizard => wizard.Creator == "J.K. Rowling")
                      .Select(wizard => wizard.Name);
    }

    public static IEnumerable<string> GetRowlingWizardsWithLinqQuery(WizardCollection wizards)
    {
        var rowlingWizards = from wiz in wizards
                             where wiz.Creator == "J.K. Rowling"
                             select wiz.Name; 
        return rowlingWizards;
    }

    public static int? GetFirstSithlordWithExtensions(WizardCollection wizards)
    {
       return wizards.Where(wizard => wizard.Name.StartsWith("Darth"))
                     .MinBy(wizard => wizard.Year)?.Year;
    }

    public static int? GetFirstSithlordWithLinqQuery(WizardCollection wizards)
    {
        var firstSithLordYear = (from wiz in wizards
                                where wiz.Name.StartsWith("Darth")
                                select wiz.Year).Min();
        return firstSithLordYear;
    }

    public static IEnumerable<(string name, int year)> GetUniqueHarryPotterWizardsWithExtensions(WizardCollection wizard) => throw new NotImplementedException();

    public static IEnumerable<(string name, int year)> GetUniqueHarryPotterWizardsWithLinqQuery(WizardCollection wizard) => throw new NotImplementedException();
}
