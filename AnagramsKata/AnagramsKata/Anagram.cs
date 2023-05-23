namespace AnagramsKata.Tests;

public class Anagram
{
    public static List<string> Of(string s)
    {
        if (s == "") return new List<string> { "" };

        return new List<string> { s };
    }
}