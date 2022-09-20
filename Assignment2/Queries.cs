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

    public static IEnumerable<(string name, int? year)> GetUniqueHarryPotterWizardsWithExtensions(WizardCollection wizards)
    {
        return wizards.Where(wizard => wizard.Medium == "Harry Potter").Select(wizard => (wizard.Name, wizard.Year));
    }

    public static IEnumerable<(string name, int? year)> GetUniqueHarryPotterWizardsWithLinqQuery(WizardCollection wizards)
    {
        var uniqueHarryPotterTuples = from wiz in wizards
                                      where wiz.Medium == "Harry Potter"
                                      select (wiz.Name, wiz.Year);
        return uniqueHarryPotterTuples;
    }
}
