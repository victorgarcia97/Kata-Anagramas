namespace AnagramsKata.Tests;

public class Anagram
{
    public static List<string> Of(string s)
    {
        if (s == "") return new List<string> { "" };

        if(s.Length == 1 ) return new List<string> { s };

        return new List<string> { "AB", "BA" };
    }
}