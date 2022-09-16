namespace Assignment2;

using System.Text.RegularExpressions;
public static class Extensions
{
    public static bool IsSecure(this Uri uri) => uri.ToString().StartsWith("https");

    public static int WordCount(this string str) => Regex.Matches(str, @"\w+").Count();
}
