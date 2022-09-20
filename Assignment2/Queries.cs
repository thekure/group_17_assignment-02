namespace Assignment2;

public class Queries
{
    public static IEnumerable<string> GetRowlingWizardsWithExtensions(WizardCollection wizards)
    {
        return wizards.Where(wizard => wizard.Creator == "J.K. Rowling").Select(wizard => wizard.Name);
    }

    public static IEnumerable<string> GetRowlingWizardsWithLinqQuery(WizardCollection wizards)
    {
        var rowlingWizards = from wiz in wizards
                             where wiz.Creator == "J.K. Rowling"
                             select wiz.Name; 
        return rowlingWizards;
    }
}
